﻿using System;
using System.Xml;
using System.Xml.Xsl;
using System.Xml.XPath;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ImageMagick;

namespace Asset_Bundle_Creator
{
    public partial class MainForm : Form
    {
        public string newFileName;
        public bool compileImages = false;
        private bool isSetFilename;
        private bool isSetXMLSource;
        private bool isSetOutputFolder;
        private bool isSetImageSource;


        public MainForm()
        {
            InitializeComponent();
        }

        private void XMLFilename_TextChanged(object sender, EventArgs e)
        {
            bool isCorrect = XMLFilename.Text.Contains(".xml") || XMLFilename.Text.Contains(".XML");
            string tmp = isCorrect ? XMLFilename.Text : XMLFilename.Text + ".xml";
            newFileName = tmp;
            XMLFilename.Text = tmp.Replace(" ", string.Empty);
            XMLFilename.SelectionStart = XMLFilename.Text.Length - 4;
            isSetFilename = true;
        }

        private void XMLFilename_Click(object sender, EventArgs e)
        {
            XMLFilename.Select(0, XMLFilename.Text.IndexOf("."));
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {

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
            if (isSetFilename && isSetImageSource && isSetOutputFolder && isSetXMLSource)
            {
                try
                {
                    string readerText = this.DBSourceString.Text;
                    string filepath = OutputFolderString.Text +  "\\" + newFileName;
                    string folderpath = ImageSourceString.Text;
                    XslCompiledTransform transform = new XslCompiledTransform();
                    transform.Load("XSL_APP_XML.xsl");
                    transform.Transform(@readerText, @filepath);

                    XmlDocument document = new XmlDocument();
                    document.Load(@filepath);

                    XPathNavigator navigator = document.CreateNavigator();
                    bool beEdit = navigator.CanEdit;

                    foreach(XPathNavigator nav in navigator.Select("cards/card/cells/cell/asset"))
                    {
                        if(nav.Value.Contains("_1.jpg"))
                        {
                            nav.SetValue(nav.Value.Substring(0, nav.Value.LastIndexOf('_')) + ".png");
                        }
                        else if (nav.Value.Contains(".jpg"))
                        {
                            nav.SetValue(nav.Value.Substring(0, nav.Value.LastIndexOf('.')) + ".png");
                        }
                        if (compileImages)
                        {
                            var fileLookup = folderpath +  "\\" + nav.Value.Substring(0, nav.Value.LastIndexOf(".")) + ".psd";
                            if (File.Exists(@fileLookup))
                            {
                                MagickReadSettings settings = new MagickReadSettings();
                                settings.ColorSpace = ColorSpace.RGB;
                                MagickImage image = new MagickImage();
                                image.Read(@folderpath + "\\" + nav.Value.Substring(0, nav.Value.LastIndexOf(".")) + ".psd", settings);
                                image.Resize(400, 400);
                                image.Write(OutputFolderString.Text + "\\" + nav.Value.Substring(0, nav.Value.LastIndexOf(".")) + ".png");
                            }
                        }
                    }

                    document.Save(@filepath);
                }
                catch (InvalidCastException e)
                {
                    
                }
            }
            else
            {
                MessageBox.Show("Filename must have the extension *.xml", "Formating Incorrect", MessageBoxButtons.OK);
            }
        }

        private void DBSourceBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.DBSourceString.Text = this.openFileDialog.FileName;
                isSetXMLSource = true;
            }
            else
            {
                isSetXMLSource = false;
            }
        }

        private void OutputFolderBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = this.folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.OutputFolderString.Text = this.folderBrowserDialog1.SelectedPath;
                isSetOutputFolder = true;
            }
            else
            {
                isSetOutputFolder = false;
            }
        }

        private void ImageSourceBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = this.folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.ImageSourceString.Text = this.folderBrowserDialog1.SelectedPath;
                isSetImageSource = true;
            }
            else
            {
                isSetImageSource = false;
            }
        }
    }
}
