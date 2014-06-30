using System;
using System.Xml;
using System.Xml.Xsl;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Asset_Bundle_Creator
{
    public partial class MainForm : Form
    {
        public string newFileName;
        public bool compileImages = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void XMLFilename_TextChanged(object sender, EventArgs e)
        {
            newFileName = this.XMLFilename.Text;
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.filepath.Text = this.openFileDialog.FileName;
            }
        }

        private void Go_Click(object sender, EventArgs e)
        {
            Transform();
        }

        private void CompileImages_CheckedChanged(object sender, EventArgs e)
        {
            compileImages = compileImages == true ? false : true;
        }

        private void filepath_TextChanged(object sender, EventArgs e)
        {

        }

        private void Transform()
        { 
            if(newFileName != "" && this.filepath.Text != "" ) 
            {
                string readerText = this.filepath.Text;
                XmlReader reader = XmlReader.Create(readerText);
                XmlWriter writer = XmlWriter.Create(newFileName);
                XslCompiledTransform transform = new XslCompiledTransform();
                transform.Load("XSL_APP_XML.xsl");
                transform.Transform(@readerText, @"output.xml");
            }
        }
    }
}
