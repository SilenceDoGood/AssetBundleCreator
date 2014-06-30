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
            this.Filename = new System.Windows.Forms.Label();
            this.filepath = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.DBXMLLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // CompileImages
            // 
            this.CompileImages.AccessibleName = "CompileImages";
            this.CompileImages.AutoSize = true;
            this.CompileImages.Location = new System.Drawing.Point(12, 107);
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
            this.XMLFilename.TextChanged += new System.EventHandler(this.XMLFilename_TextChanged);
            // 
            // Go
            // 
            this.Go.AccessibleName = "Go";
            this.Go.Location = new System.Drawing.Point(208, 145);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(75, 23);
            this.Go.TabIndex = 2;
            this.Go.Text = "Go";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // Filename
            // 
            this.Filename.AccessibleName = "File Name Label";
            this.Filename.AutoSize = true;
            this.Filename.Location = new System.Drawing.Point(9, 6);
            this.Filename.Name = "Filename";
            this.Filename.Size = new System.Drawing.Size(109, 13);
            this.Filename.TabIndex = 3;
            this.Filename.Text = "Filename of new XML";
            this.Filename.Click += new System.EventHandler(this.label1_Click);
            // 
            // filepath
            // 
            this.filepath.AccessibleName = "filepath";
            this.filepath.Location = new System.Drawing.Point(12, 68);
            this.filepath.Name = "filepath";
            this.filepath.ReadOnly = true;
            this.filepath.Size = new System.Drawing.Size(190, 20);
            this.filepath.TabIndex = 4;
            this.filepath.TextChanged += new System.EventHandler(this.filepath_TextChanged);
            // 
            // BrowseButton
            // 
            this.BrowseButton.AccessibleName = "Browse";
            this.BrowseButton.Location = new System.Drawing.Point(208, 68);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton.TabIndex = 5;
            this.BrowseButton.Text = "Browse...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // DBXMLLabel
            // 
            this.DBXMLLabel.AccessibleName = "DBXMLLabel";
            this.DBXMLLabel.AutoSize = true;
            this.DBXMLLabel.Location = new System.Drawing.Point(9, 52);
            this.DBXMLLabel.Name = "DBXMLLabel";
            this.DBXMLLabel.Size = new System.Drawing.Size(78, 13);
            this.DBXMLLabel.TabIndex = 6;
            this.DBXMLLabel.Text = "Database XML";
            this.DBXMLLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Title = "openFileDialog";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 180);
            this.Controls.Add(this.DBXMLLabel);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.filepath);
            this.Controls.Add(this.Filename);
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
        private System.Windows.Forms.Label Filename;
        private System.Windows.Forms.TextBox filepath;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Label DBXMLLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

