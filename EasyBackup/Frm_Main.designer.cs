namespace EasyBackup
{
    partial class Frm_Main
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
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.Bf_DestinationDirectory = new EasyBackup.BrowseFolder();
            this.Bf_SourceDirectory = new EasyBackup.BrowseFolder();
            this.SuspendLayout();
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Ok.Location = new System.Drawing.Point(268, 115);
            this.Btn_Ok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(88, 27);
            this.Btn_Ok.TabIndex = 2;
            this.Btn_Ok.Text = "OK";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // Bf_DestinationDirectory
            // 
            // 
            // 
            // 
            this.Bf_DestinationDirectory.Button_BrowseDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bf_DestinationDirectory.Button_BrowseDirectory.Location = new System.Drawing.Point(438, 2);
            this.Bf_DestinationDirectory.Button_BrowseDirectory.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.Bf_DestinationDirectory.Button_BrowseDirectory.Name = "Btn_BrowseDirectory";
            this.Bf_DestinationDirectory.Button_BrowseDirectory.Size = new System.Drawing.Size(75, 24);
            this.Bf_DestinationDirectory.Button_BrowseDirectory.TabIndex = 9;
            this.Bf_DestinationDirectory.Button_BrowseDirectory.Text = "Browse...";
            this.Bf_DestinationDirectory.Button_BrowseDirectory.UseVisualStyleBackColor = true;
            // 
            // 
            // 
            this.Bf_DestinationDirectory.Label.AutoSize = true;
            this.Bf_DestinationDirectory.Label.Location = new System.Drawing.Point(-4, 6);
            this.Bf_DestinationDirectory.Label.Margin = new System.Windows.Forms.Padding(0);
            this.Bf_DestinationDirectory.Label.Name = "Lbl";
            this.Bf_DestinationDirectory.Label.Size = new System.Drawing.Size(104, 15);
            this.Bf_DestinationDirectory.Label.TabIndex = 8;
            this.Bf_DestinationDirectory.Label.Text = "Destination folder:";
            this.Bf_DestinationDirectory.Location = new System.Drawing.Point(16, 42);
            this.Bf_DestinationDirectory.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.Bf_DestinationDirectory.Name = "Bf_DestinationDirectory";
            this.Bf_DestinationDirectory.SelectedPath = "";
            this.Bf_DestinationDirectory.Size = new System.Drawing.Size(518, 28);
            this.Bf_DestinationDirectory.TabIndex = 12;
            // 
            // 
            // 
            this.Bf_DestinationDirectory.TextBox_DirectoryFullPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bf_DestinationDirectory.TextBox_DirectoryFullPath.Location = new System.Drawing.Point(104, 2);
            this.Bf_DestinationDirectory.TextBox_DirectoryFullPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Bf_DestinationDirectory.TextBox_DirectoryFullPath.Name = "TxtBox_DirectoryFullPath";
            this.Bf_DestinationDirectory.TextBox_DirectoryFullPath.Size = new System.Drawing.Size(328, 23);
            this.Bf_DestinationDirectory.TextBox_DirectoryFullPath.TabIndex = 7;
            // 
            // Bf_SourceDirectory
            // 
            // 
            // 
            // 
            this.Bf_SourceDirectory.Button_BrowseDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bf_SourceDirectory.Button_BrowseDirectory.Location = new System.Drawing.Point(438, 2);
            this.Bf_SourceDirectory.Button_BrowseDirectory.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.Bf_SourceDirectory.Button_BrowseDirectory.Name = "Btn_BrowseDirectory";
            this.Bf_SourceDirectory.Button_BrowseDirectory.Size = new System.Drawing.Size(75, 24);
            this.Bf_SourceDirectory.Button_BrowseDirectory.TabIndex = 9;
            this.Bf_SourceDirectory.Button_BrowseDirectory.Text = "Browse...";
            this.Bf_SourceDirectory.Button_BrowseDirectory.UseVisualStyleBackColor = true;
            // 
            // 
            // 
            this.Bf_SourceDirectory.Label.AutoSize = true;
            this.Bf_SourceDirectory.Label.Location = new System.Drawing.Point(-4, 6);
            this.Bf_SourceDirectory.Label.Margin = new System.Windows.Forms.Padding(0);
            this.Bf_SourceDirectory.Label.Name = "Lbl";
            this.Bf_SourceDirectory.Label.Size = new System.Drawing.Size(80, 15);
            this.Bf_SourceDirectory.Label.TabIndex = 8;
            this.Bf_SourceDirectory.Label.Text = "Source folder:";
            this.Bf_SourceDirectory.Location = new System.Drawing.Point(16, 12);
            this.Bf_SourceDirectory.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.Bf_SourceDirectory.Name = "Bf_SourceDirectory";
            this.Bf_SourceDirectory.SelectedPath = "";
            this.Bf_SourceDirectory.Size = new System.Drawing.Size(518, 28);
            this.Bf_SourceDirectory.TabIndex = 13;
            // 
            // 
            // 
            this.Bf_SourceDirectory.TextBox_DirectoryFullPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bf_SourceDirectory.TextBox_DirectoryFullPath.Location = new System.Drawing.Point(104, 2);
            this.Bf_SourceDirectory.TextBox_DirectoryFullPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Bf_SourceDirectory.TextBox_DirectoryFullPath.Name = "TxtBox_DirectoryFullPath";
            this.Bf_SourceDirectory.TextBox_DirectoryFullPath.Size = new System.Drawing.Size(328, 23);
            this.Bf_SourceDirectory.TextBox_DirectoryFullPath.TabIndex = 7;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 156);
            this.Controls.Add(this.Bf_SourceDirectory);
            this.Controls.Add(this.Bf_DestinationDirectory);
            this.Controls.Add(this.Btn_Ok);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Frm_Main";
            this.Text = "EasyBackup";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_Ok;
        private BrowseFolder Bf_DestinationDirectory;
        private BrowseFolder Bf_SourceDirectory;
    }
}

