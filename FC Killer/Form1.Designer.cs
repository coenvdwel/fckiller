namespace FC_Killer
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.searchButton = new System.Windows.Forms.Button();
      this.searchField = new System.Windows.Forms.TextBox();
      this.fixThisButton = new System.Windows.Forms.Button();
      this.fixAllButton = new System.Windows.Forms.Button();
      this.listField = new System.Windows.Forms.ListBox();
      this.detailField = new System.Windows.Forms.RichTextBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
      this.progressLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.browseFileButton = new System.Windows.Forms.Button();
      this.browseFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.browseFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
      this.browseFolderButton = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.stopButton = new System.Windows.Forms.Button();
      this.ignoreButton = new System.Windows.Forms.Button();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // searchButton
      // 
      this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
      this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.searchButton.Location = new System.Drawing.Point(716, 12);
      this.searchButton.Name = "searchButton";
      this.searchButton.Size = new System.Drawing.Size(98, 23);
      this.searchButton.TabIndex = 3;
      this.searchButton.Text = "&Search";
      this.searchButton.UseVisualStyleBackColor = true;
      this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
      // 
      // searchField
      // 
      this.searchField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.searchField.Location = new System.Drawing.Point(45, 14);
      this.searchField.Name = "searchField";
      this.searchField.Size = new System.Drawing.Size(444, 20);
      this.searchField.TabIndex = 0;
      // 
      // fixThisButton
      // 
      this.fixThisButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.fixThisButton.Enabled = false;
      this.fixThisButton.Image = ((System.Drawing.Image)(resources.GetObject("fixThisButton.Image")));
      this.fixThisButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.fixThisButton.Location = new System.Drawing.Point(716, 295);
      this.fixThisButton.Name = "fixThisButton";
      this.fixThisButton.Size = new System.Drawing.Size(98, 23);
      this.fixThisButton.TabIndex = 6;
      this.fixThisButton.Text = "Fix &this one!";
      this.fixThisButton.UseVisualStyleBackColor = true;
      this.fixThisButton.Click += new System.EventHandler(this.fixThisButton_Click);
      // 
      // fixAllButton
      // 
      this.fixAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.fixAllButton.Enabled = false;
      this.fixAllButton.Image = ((System.Drawing.Image)(resources.GetObject("fixAllButton.Image")));
      this.fixAllButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.fixAllButton.Location = new System.Drawing.Point(716, 324);
      this.fixAllButton.Name = "fixAllButton";
      this.fixAllButton.Size = new System.Drawing.Size(98, 23);
      this.fixAllButton.TabIndex = 7;
      this.fixAllButton.Text = "Fix &all these!";
      this.fixAllButton.UseVisualStyleBackColor = true;
      this.fixAllButton.Click += new System.EventHandler(this.fixAllButton_Click);
      // 
      // listField
      // 
      this.listField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.listField.DisplayMember = "Text";
      this.listField.FormattingEnabled = true;
      this.listField.HorizontalScrollbar = true;
      this.listField.Location = new System.Drawing.Point(2, 3);
      this.listField.Name = "listField";
      this.listField.Size = new System.Drawing.Size(333, 303);
      this.listField.TabIndex = 5;
      this.listField.ValueMember = "Text";
      this.listField.SelectedIndexChanged += new System.EventHandler(this.listField_SelectedIndexChanged);
      // 
      // detailField
      // 
      this.detailField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.detailField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.detailField.Location = new System.Drawing.Point(3, 3);
      this.detailField.Name = "detailField";
      this.detailField.ReadOnly = true;
      this.detailField.Size = new System.Drawing.Size(342, 303);
      this.detailField.TabIndex = 7;
      this.detailField.TabStop = false;
      this.detailField.Text = "";
      this.detailField.WordWrap = false;
      // 
      // panel1
      // 
      this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
      this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.panel1.Location = new System.Drawing.Point(716, 70);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(98, 97);
      this.panel1.TabIndex = 9;
      // 
      // splitContainer1
      // 
      this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.splitContainer1.Location = new System.Drawing.Point(10, 41);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.listField);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.detailField);
      this.splitContainer1.Size = new System.Drawing.Size(690, 313);
      this.splitContainer1.SplitterDistance = 338;
      this.splitContainer1.TabIndex = 4;
      this.splitContainer1.TabStop = false;
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.progressLabel});
      this.statusStrip1.Location = new System.Drawing.Point(0, 363);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(826, 22);
      this.statusStrip1.TabIndex = 11;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // progressBar
      // 
      this.progressBar.Name = "progressBar";
      this.progressBar.Size = new System.Drawing.Size(100, 16);
      // 
      // progressLabel
      // 
      this.progressLabel.Name = "progressLabel";
      this.progressLabel.Size = new System.Drawing.Size(39, 17);
      this.progressLabel.Text = "Ready.";
      // 
      // browseFileButton
      // 
      this.browseFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.browseFileButton.Image = ((System.Drawing.Image)(resources.GetObject("browseFileButton.Image")));
      this.browseFileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.browseFileButton.Location = new System.Drawing.Point(495, 12);
      this.browseFileButton.Name = "browseFileButton";
      this.browseFileButton.Size = new System.Drawing.Size(98, 23);
      this.browseFileButton.TabIndex = 1;
      this.browseFileButton.Text = "F&ile";
      this.browseFileButton.UseVisualStyleBackColor = true;
      this.browseFileButton.Click += new System.EventHandler(this.browseFileButton_Click);
      // 
      // browseFileDialog
      // 
      this.browseFileDialog.Filter = "Javascript files|*.js|All files|*.*";
      this.browseFileDialog.Title = "Browse file or folder...";
      // 
      // browseFolderButton
      // 
      this.browseFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.browseFolderButton.Image = ((System.Drawing.Image)(resources.GetObject("browseFolderButton.Image")));
      this.browseFolderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.browseFolderButton.Location = new System.Drawing.Point(599, 12);
      this.browseFolderButton.Name = "browseFolderButton";
      this.browseFolderButton.Size = new System.Drawing.Size(98, 23);
      this.browseFolderButton.TabIndex = 2;
      this.browseFolderButton.Text = "F&older";
      this.browseFolderButton.UseVisualStyleBackColor = true;
      this.browseFolderButton.Click += new System.EventHandler(this.browseFolderButton_Click);
      // 
      // panel2
      // 
      this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
      this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.panel2.Location = new System.Drawing.Point(12, 14);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(27, 20);
      this.panel2.TabIndex = 14;
      // 
      // stopButton
      // 
      this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.stopButton.Enabled = false;
      this.stopButton.Image = ((System.Drawing.Image)(resources.GetObject("stopButton.Image")));
      this.stopButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.stopButton.Location = new System.Drawing.Point(716, 41);
      this.stopButton.Name = "stopButton";
      this.stopButton.Size = new System.Drawing.Size(98, 23);
      this.stopButton.TabIndex = 15;
      this.stopButton.Text = "&Stop";
      this.stopButton.UseVisualStyleBackColor = true;
      this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
      // 
      // ignoreButton
      // 
      this.ignoreButton.Enabled = false;
      this.ignoreButton.Image = ((System.Drawing.Image)(resources.GetObject("ignoreButton.Image")));
      this.ignoreButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.ignoreButton.Location = new System.Drawing.Point(716, 266);
      this.ignoreButton.Name = "ignoreButton";
      this.ignoreButton.Size = new System.Drawing.Size(98, 23);
      this.ignoreButton.TabIndex = 16;
      this.ignoreButton.Text = "I&gnore";
      this.ignoreButton.UseVisualStyleBackColor = true;
      this.ignoreButton.Click += new System.EventHandler(this.ignoreButton_Click);
      // 
      // Form1
      // 
      this.AcceptButton = this.searchButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.ClientSize = new System.Drawing.Size(826, 385);
      this.Controls.Add(this.ignoreButton);
      this.Controls.Add(this.stopButton);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.browseFolderButton);
      this.Controls.Add(this.browseFileButton);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.fixAllButton);
      this.Controls.Add(this.fixThisButton);
      this.Controls.Add(this.searchField);
      this.Controls.Add(this.searchButton);
      this.DoubleBuffered = true;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.Text = "FC Killer";
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.ResumeLayout(false);
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button searchButton;
    private System.Windows.Forms.TextBox searchField;
    private System.Windows.Forms.Button fixThisButton;
    private System.Windows.Forms.Button fixAllButton;
    private System.Windows.Forms.ListBox listField;
    private System.Windows.Forms.RichTextBox detailField;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.Button browseFileButton;
    private System.Windows.Forms.OpenFileDialog browseFileDialog;
    private System.Windows.Forms.ToolStripProgressBar progressBar;
    private System.Windows.Forms.ToolStripStatusLabel progressLabel;
    private System.Windows.Forms.FolderBrowserDialog browseFolderDialog;
    private System.Windows.Forms.Button browseFolderButton;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button stopButton;
    private System.Windows.Forms.Button ignoreButton;
  }
}

