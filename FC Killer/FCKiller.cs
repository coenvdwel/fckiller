using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FC_Killer
{
  class FCKiller
  {

    public delegate void CheckEventHandler(string file);
    public delegate void DoneEventHandler();
    public delegate void AddEventHandler(string file, int line, int index);

    private readonly Regex _regex = new Regex(@"[^\\],\s*[\}\]\)]");
    private const int Env = 10;
    private bool _running;
    public event CheckEventHandler Check;
    public event DoneEventHandler Done;
    public event AddEventHandler Add;

    public void Search(string root)
    {
      _running = true;
      if (Directory.Exists(root)) CheckDir(root);
      else if (File.Exists(root)) CheckFile(root);
      else MessageBox.Show("Could not find file or folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      Done();
    }

    public void Stop()
    {
      _running = false;
    }

    private void CheckDir(string dir)
    {
      if (!_running) return;

      Check(dir);

      foreach (var f in Directory.GetFiles(dir)) CheckFile(f);
      foreach (var d in Directory.GetDirectories(dir)) CheckDir(d);
    }

    private void CheckFile(string file)
    {
      if (!_running) return;
      if (!file.EndsWith(".js")) return;

      Check(file);

      var content = File.ReadAllText(file);
      var matches = _regex.Matches(content);
      foreach (Match match in matches)
      {
        Add(file, GetLineNumber(content, match.Index), match.Index);
      }
    }

    public void Fix(string file, int index)
    {
      var content = File.ReadAllText(file);
      if (content.Length <= index || content[index+1] != ',')
      {
        MessageBox.Show("This file contains no comma on specified location!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        content = content.Remove(index+1, 1);
        File.WriteAllText(file, content);
      }
    }

    public string[] GetDetails(string file, int line, out int outLine)
    {
      var c = File.ReadAllText(file).Split('\n');
      var r = new List<string>();
      outLine = -1;
      for (var i = Math.Max(0, line - Env); i < Math.Min(line + Env, c.Length); i++)
      {
        r.Add(c[i]);
        if (i+1 == line)
        {
          outLine = r.Count-1;
        }
      }
      return r.ToArray();
    }

    static int GetLineNumber(string content, int index)
    {
      var line = 1;
      for (var i = 0; i < index; i++)
      {
        if (content[i] == '\n') line++;
      }
      return line;
    }


  }
}
