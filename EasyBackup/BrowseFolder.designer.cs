namespace EasyBackup
{
    partial class BrowseFolder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_BrowseDirectory = new System.Windows.Forms.Button();
            this.Lbl = new System.Windows.Forms.Label();
            this.TxtBox_DirectoryFullPath = new System.Windows.Forms.TextBox();
            this.Fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // Btn_BrowseDirectory
            // 
            this.Btn_BrowseDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_BrowseDirectory.Location = new System.Drawing.Point(365, 0);
            this.Btn_BrowseDirectory.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Btn_BrowseDirectory.Name = "Btn_BrowseDirectory";
            this.Btn_BrowseDirectory.Size = new System.Drawing.Size(75, 23);
            this.Btn_BrowseDirectory.TabIndex = 9;
            this.Btn_BrowseDirectory.Text = "Browse...";
            this.Btn_BrowseDirectory.UseVisualStyleBackColor = true;
            this.Btn_BrowseDirectory.Click += new System.EventHandler(this.Btn_BrowseDirectory_Click);
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.Location = new System.Drawing.Point(-3, 5);
            this.Lbl.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(31, 13);
            this.Lbl.TabIndex = 8;
            this.Lbl.Text = "Text:";
            // 
            // TxtBox_DirectoryFullPath
            // 
            this.TxtBox_DirectoryFullPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBox_DirectoryFullPath.Location = new System.Drawing.Point(31, 2);
            this.TxtBox_DirectoryFullPath.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.TxtBox_DirectoryFullPath.Name = "TxtBox_DirectoryFullPath";
            this.TxtBox_DirectoryFullPath.Size = new System.Drawing.Size(328, 20);
            this.TxtBox_DirectoryFullPath.TabIndex = 7;
            this.TxtBox_DirectoryFullPath.TextChanged += new System.EventHandler(this.TxtBox_DirectoryFullPath_TextChanged);
            // 
            // BrowseFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_BrowseDirectory);
            this.Controls.Add(this.Lbl);
            this.Controls.Add(this.TxtBox_DirectoryFullPath);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "BrowseFolder";
            this.Size = new System.Drawing.Size(440, 22);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button Btn_BrowseDirectory;
        public System.Windows.Forms.TextBox TxtBox_DirectoryFullPath;
        public System.Windows.Forms.Label Lbl;
        public System.Windows.Forms.FolderBrowserDialog Fbd;
    }
}
