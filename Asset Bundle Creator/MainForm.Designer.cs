namespace Asset_Bundle_Creator
{
    partial class MainForm
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
            this.CompileImages = new System.Windows.Forms.CheckBox();
            this.XMLFilename = new System.Windows.Forms.TextBox();
            this.Go = new System.Windows.Forms.Button();
            this.DBSourceString = new System.Windows.Forms.TextBox();
            this.DBSourceBrowse = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.OutputFolderString = new System.Windows.Forms.TextBox();
            this.OutputFolderBrowse = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.ImageSourceBrowse = new System.Windows.Forms.Button();
            this.ImageSourceString = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CompileImages
            // 
            this.CompileImages.AccessibleName = "CompileImages";
            this.CompileImages.AutoSize = true;
            this.CompileImages.Location = new System.Drawing.Point(12, 207);
            this.CompileImages.Name = "CompileImages";
            this.CompileImages.Size = new System.Drawing.Size(106, 17);
            this.CompileImages.TabIndex = 0;
            this.CompileImages.Text = "Compile Images?";
            this.CompileImages.UseVisualStyleBackColor = true;
            this.CompileImages.CheckedChanged += new System.EventHandler(this.CompileImages_CheckedChanged);
            // 
            // XMLFilename
            // 
            this.XMLFilename.Location = new System.Drawing.Point(12, 22);
            this.XMLFilename.Name = "XMLFilename";
            this.XMLFilename.Size = new System.Drawing.Size(175, 20);
            this.XMLFilename.TabIndex = 1;
            this.XMLFilename.Text = "Output Filename.xml";
            this.XMLFilename.WordWrap = false;
            this.XMLFilename.Click += new System.EventHandler(this.XMLFilename_Click);
            this.XMLFilename.TextChanged += new System.EventHandler(this.XMLFilename_TextChanged);
            // 
            // Go
            // 
            this.Go.AccessibleName = "Go";
            this.Go.Location = new System.Drawing.Point(444, 262);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(75, 23);
            this.Go.TabIndex = 2;
            this.Go.Text = "Go";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // DBSourceString
            // 
            this.DBSourceString.AccessibleName = "filepath";
            this.DBSourceString.Location = new System.Drawing.Point(12, 71);
            this.DBSourceString.Name = "DBSourceString";
            this.DBSourceString.ReadOnly = true;
            this.DBSourceString.Size = new System.Drawing.Size(190, 20);
            this.DBSourceString.TabIndex = 4;
            this.DBSourceString.Text = "Source XML Location";
            this.DBSourceString.TextChanged += new System.EventHandler(this.filepath_TextChanged);
            // 
            // DBSourceBrowse
            // 
            this.DBSourceBrowse.AccessibleName = "Browse";
            this.DBSourceBrowse.Location = new System.Drawing.Point(208, 68);
            this.DBSourceBrowse.Name = "DBSourceBrowse";
            this.DBSourceBrowse.Size = new System.Drawing.Size(75, 23);
            this.DBSourceBrowse.TabIndex = 5;
            this.DBSourceBrowse.Text = "Browse...";
            this.DBSourceBrowse.UseVisualStyleBackColor = true;
            this.DBSourceBrowse.Click += new System.EventHandler(this.DBSourceBrowse_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Title = "openFileDialog";
            // 
            // OutputFolderString
            // 
            this.OutputFolderString.Location = new System.Drawing.Point(12, 116);
            this.OutputFolderString.Name = "OutputFolderString";
            this.OutputFolderString.ReadOnly = true;
            this.OutputFolderString.Size = new System.Drawing.Size(190, 20);
            this.OutputFolderString.TabIndex = 7;
            this.OutputFolderString.Text = "Output Folder Location";
            // 
            // OutputFolderBrowse
            // 
            this.OutputFolderBrowse.Location = new System.Drawing.Point(208, 113);
            this.OutputFolderBrowse.Name = "OutputFolderBrowse";
            this.OutputFolderBrowse.Size = new System.Drawing.Size(75, 23);
            this.OutputFolderBrowse.TabIndex = 8;
            this.OutputFolderBrowse.Text = "Browse...";
            this.OutputFolderBrowse.UseVisualStyleBackColor = true;
            this.OutputFolderBrowse.Click += new System.EventHandler(this.OutputFolderBrowse_Click);
            // 
            // ImageSourceBrowse
            // 
            this.ImageSourceBrowse.Location = new System.Drawing.Point(208, 157);
            this.ImageSourceBrowse.Name = "ImageSourceBrowse";
            this.ImageSourceBrowse.Size = new System.Drawing.Size(75, 23);
            this.ImageSourceBrowse.TabIndex = 9;
            this.ImageSourceBrowse.Text = "Browse...";
            this.ImageSourceBrowse.UseVisualStyleBackColor = true;
            this.ImageSourceBrowse.Click += new System.EventHandler(this.ImageSourceBrowse_Click);
            // 
            // ImageSourceString
            // 
            this.ImageSourceString.Location = new System.Drawing.Point(12, 160);
            this.ImageSourceString.Name = "ImageSourceString";
            this.ImageSourceString.ReadOnly = true;
            this.ImageSourceString.Size = new System.Drawing.Size(190, 20);
            this.ImageSourceString.TabIndex = 10;
            this.ImageSourceString.Text = "Image Source Folder";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 297);
            this.Controls.Add(this.ImageSourceString);
            this.Controls.Add(this.ImageSourceBrowse);
            this.Controls.Add(this.OutputFolderBrowse);
            this.Controls.Add(this.OutputFolderString);
            this.Controls.Add(this.DBSourceBrowse);
            this.Controls.Add(this.DBSourceString);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.XMLFilename);
            this.Controls.Add(this.CompileImages);
            this.Name = "MainForm";
            this.Text = "Asset Bundle Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CompileImages;
        private System.Windows.Forms.TextBox XMLFilename;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.TextBox DBSourceString;
        private System.Windows.Forms.Button DBSourceBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox OutputFolderString;
        private System.Windows.Forms.Button OutputFolderBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button ImageSourceBrowse;
        private System.Windows.Forms.TextBox ImageSourceString;
    }
}

