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
            this.Bf_DestinationDirectory.SuspendLayout();
            this.Bf_SourceDirectory.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Ok.Location = new System.Drawing.Point(230, 100);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ok.TabIndex = 2;
            this.Btn_Ok.Text = "OK";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // Bf_DestinationDirectory
            // 
            this.Bf_DestinationDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // Bf_DestinationDirectory.Btn_BrowseDirectory
            // 
            this.Bf_DestinationDirectory.Button_BrowseDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bf_DestinationDirectory.Button_BrowseDirectory.Location = new System.Drawing.Point(432, 0);
            this.Bf_DestinationDirectory.Button_BrowseDirectory.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Bf_DestinationDirectory.Button_BrowseDirectory.Name = "Btn_BrowseDirectory";
            this.Bf_DestinationDirectory.Button_BrowseDirectory.Size = new System.Drawing.Size(75, 23);
            this.Bf_DestinationDirectory.Button_BrowseDirectory.TabIndex = 9;
            this.Bf_DestinationDirectory.Button_BrowseDirectory.Text = "Browse...";
            this.Bf_DestinationDirectory.Button_BrowseDirectory.UseVisualStyleBackColor = true;
            // 
            // Bf_DestinationDirectory.Lbl
            // 
            this.Bf_DestinationDirectory.Label.AutoSize = true;
            this.Bf_DestinationDirectory.Label.Location = new System.Drawing.Point(-3, 5);
            this.Bf_DestinationDirectory.Label.Margin = new System.Windows.Forms.Padding(0);
            this.Bf_DestinationDirectory.Label.Name = "Lbl";
            this.Bf_DestinationDirectory.Label.Size = new System.Drawing.Size(95, 13);
            this.Bf_DestinationDirectory.Label.TabIndex = 8;
            this.Bf_DestinationDirectory.Label.Text = "Destination Folder:";
            this.Bf_DestinationDirectory.Location = new System.Drawing.Point(14, 36);
            this.Bf_DestinationDirectory.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Bf_DestinationDirectory.Name = "Bf_DestinationDirectory";
            this.Bf_DestinationDirectory.SelectedPath = "";
            this.Bf_DestinationDirectory.Size = new System.Drawing.Size(507, 22);
            this.Bf_DestinationDirectory.TabIndex = 8;
            // 
            // Bf_DestinationDirectory.TxtBox_DirectoryFullPath
            // 
            this.Bf_DestinationDirectory.TextBox_DirectoryFullPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bf_DestinationDirectory.TextBox_DirectoryFullPath.Location = new System.Drawing.Point(98, 2);
            this.Bf_DestinationDirectory.TextBox_DirectoryFullPath.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Bf_DestinationDirectory.TextBox_DirectoryFullPath.Name = "TxtBox_DirectoryFullPath";
            this.Bf_DestinationDirectory.TextBox_DirectoryFullPath.Size = new System.Drawing.Size(328, 20);
            this.Bf_DestinationDirectory.TextBox_DirectoryFullPath.TabIndex = 7;
            // 
            // Bf_SourceDirectory
            // 
            // 
            // Bf_SourceDirectory.Btn_BrowseDirectory
            // 
            this.Bf_SourceDirectory.Button_BrowseDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bf_SourceDirectory.Button_BrowseDirectory.Location = new System.Drawing.Point(432, 0);
            this.Bf_SourceDirectory.Button_BrowseDirectory.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Bf_SourceDirectory.Button_BrowseDirectory.Name = "Btn_BrowseDirectory";
            this.Bf_SourceDirectory.Button_BrowseDirectory.Size = new System.Drawing.Size(75, 23);
            this.Bf_SourceDirectory.Button_BrowseDirectory.TabIndex = 9;
            this.Bf_SourceDirectory.Button_BrowseDirectory.Text = "Browse...";
            this.Bf_SourceDirectory.Button_BrowseDirectory.UseVisualStyleBackColor = true;
            // 
            // Bf_SourceDirectory.Lbl
            // 
            this.Bf_SourceDirectory.Label.AutoSize = true;
            this.Bf_SourceDirectory.Label.Location = new System.Drawing.Point(-3, 5);
            this.Bf_SourceDirectory.Label.Margin = new System.Windows.Forms.Padding(0);
            this.Bf_SourceDirectory.Label.Name = "Lbl";
            this.Bf_SourceDirectory.Label.Size = new System.Drawing.Size(76, 13);
            this.Bf_SourceDirectory.Label.TabIndex = 8;
            this.Bf_SourceDirectory.Label.Text = "Source Folder:";
            this.Bf_SourceDirectory.Location = new System.Drawing.Point(14, 10);
            this.Bf_SourceDirectory.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Bf_SourceDirectory.Name = "Bf_SourceDirectory";
            this.Bf_SourceDirectory.SelectedPath = "";
            this.Bf_SourceDirectory.Size = new System.Drawing.Size(507, 22);
            this.Bf_SourceDirectory.TabIndex = 9;
            // 
            // Bf_SourceDirectory.TxtBox_DirectoryFullPath
            // 
            this.Bf_SourceDirectory.TextBox_DirectoryFullPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bf_SourceDirectory.TextBox_DirectoryFullPath.Location = new System.Drawing.Point(98, 2);
            this.Bf_SourceDirectory.TextBox_DirectoryFullPath.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Bf_SourceDirectory.TextBox_DirectoryFullPath.Name = "TxtBox_DirectoryFullPath";
            this.Bf_SourceDirectory.TextBox_DirectoryFullPath.Size = new System.Drawing.Size(328, 20);
            this.Bf_SourceDirectory.TextBox_DirectoryFullPath.TabIndex = 7;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 135);
            this.Controls.Add(this.Bf_SourceDirectory);
            this.Controls.Add(this.Bf_DestinationDirectory);
            this.Controls.Add(this.Btn_Ok);
            this.DoubleBuffered = true;
            this.Name = "Frm_Main";
            this.Text = "EasyBackup";
            this.Bf_DestinationDirectory.ResumeLayout(false);
            this.Bf_DestinationDirectory.PerformLayout();
            this.Bf_SourceDirectory.ResumeLayout(false);
            this.Bf_SourceDirectory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_Ok;
        private BrowseFolder Bf_DestinationDirectory;
        private BrowseFolder Bf_SourceDirectory;
    }
}

