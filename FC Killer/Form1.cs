using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FC_Killer
{
  public partial class Form1 : Form
  {
    private readonly FCKiller _fc;

    public class ListItem
    {
      public string File;
      public string ShortName;
      public int Line;
      public int Index;
      public string Text
      {
        get { return String.Format("{0} on line {1}", ShortName, Line); }
      }
    }

    public void Check(string file)
    {
      progressLabel.Text = String.Format("Checking {0}...", file);
      Application.DoEvents();
    }

    public void Done()
    {
      searchButton.Enabled = true;
      stopButton.Enabled = false;

      progressLabel.Text = "Done.";
      progressBar.Style = ProgressBarStyle.Blocks;

      Application.DoEvents();
    }

    public void AddResult(string file, int line, int index)
    {
      listField.Items.Add(new ListItem
      {
        File = file,
        ShortName = file.Substring(searchField.Text.Length),
        Line = line,
        Index = index
      });
      fixAllButton.Enabled = true;
    }

    public Form1(string[] args)
    {
      _fc = new FCKiller();
      InitializeComponent();

      _fc.Check += Check;
      _fc.Done += Done;
      _fc.Add += AddResult;

      searchField.Text = args.Length == 1 ? args[0] : Directory.GetCurrentDirectory();
    }

    private void stopButton_Click(object sender, EventArgs e)
    {
      _fc.Stop();
    }

    private void searchButton_Click(object sender, EventArgs e)
    {
      searchButton.Enabled = false;
      stopButton.Enabled = true;

      fixAllButton.Enabled = false;
      fixThisButton.Enabled = false;
      listField.Items.Clear();
      detailField.ResetText();
      progressBar.Style = ProgressBarStyle.Marquee;
      
      _fc.Search(searchField.Text);
    }

    private void fixAllButton_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
      foreach (ListItem item in listField.Items)
      {
        _fc.Fix(item.File, item.Index);
      }
      listField_SelectedIndexChanged(sender, e);
    }

    private void fixThisButton_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
      var item = (ListItem) listField.SelectedItem;
      _fc.Fix(item.File, item.Index);
      listField_SelectedIndexChanged(sender, e);
    }

    private void listField_SelectedIndexChanged(object sender, EventArgs e)
    {
      var item = (ListItem) listField.SelectedItem;
      if (item == null) return;

      int outLine;
      var text = _fc.GetDetails(item.File, item.Line, out outLine);

      detailField.ResetText();
      for(var i = 0; i<text.Length; i++)
      {
        var currentFont = detailField.SelectionFont;
        if (i == outLine)
        {
          detailField.SelectionFont = new Font(
            currentFont.FontFamily,
            currentFont.Size,
            FontStyle.Bold
          );
        }
        detailField.AppendText(text[i] + '\n');
        if (i == outLine)
        {
          detailField.SelectionFont = currentFont;
        }
      }

      fixThisButton.Enabled = true;
      ignoreButton.Enabled = true;
    }

    private void browseFileButton_Click(object sender, EventArgs e)
    {
      if (browseFileDialog.ShowDialog(this) == DialogResult.OK)
      {
        searchField.Text = browseFileDialog.FileName;
      }
    }

    private void browseFolderButton_Click(object sender, EventArgs e)
    {
      if (browseFolderDialog.ShowDialog(this) == DialogResult.OK)
      {
        searchField.Text = browseFolderDialog.SelectedPath;
      }
    }

    private void ignoreButton_Click(object sender, EventArgs e)
    {
      var item = (ListItem)listField.SelectedItem;
      if (item == null) return;

      listField.Items.Remove(item);

      fixThisButton.Enabled = false;
      ignoreButton.Enabled = false;
    }

  }
}