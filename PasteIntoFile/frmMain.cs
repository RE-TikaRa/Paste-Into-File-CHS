﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasteAsFile.Localization;

namespace PasteAsFile
{
    public partial class frmMain : Form
    {
        public const string DEFAULT_FILENAME_FORMAT = "yyyy-MM-dd HH.mm.ss";
        public string CurrentLocation { get; set; }
        public bool IsText { get; set; }
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(string location)
        {
            InitializeComponent();
            this.CurrentLocation = location;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            // Apply localization
            ApplyLocalization();
            
            string filename = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Classes\Directory\shell\Paste Into File\filename", "", null) ?? DEFAULT_FILENAME_FORMAT;
            txtFilename.Text = DateTime.Now.ToString(filename);
            txtCurrentLocation.Text = CurrentLocation ?? @"C:\";

            if (Registry.GetValue(@"HKEY_CURRENT_USER\Software\Classes\Directory\Background\shell\Paste Into File\command", "", null) == null)
            {
                if (MessageBox.Show(LanguageManager.Current.FirstTimeMessage, LanguageManager.Current.FirstTimeTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Program.RegisterApp();
                }
            }

            if (Clipboard.ContainsText())
            {
                lblType.Text = LanguageManager.Current.TextFile;
                comExt.SelectedItem = "txt";
                IsText = true;
                txtContent.Text = Clipboard.GetText();
                return;
            }

            if (Clipboard.ContainsImage())
            {
                lblType.Text = LanguageManager.Current.Image;
                comExt.SelectedItem = "png";
                imgContent.Image = Clipboard.GetImage();
                return;
            }

            lblType.Text = LanguageManager.Current.UnknownFile;
            btnSave.Enabled = false;


        }

        private void ApplyLocalization()
        {
            var lang = LanguageManager.Current;
            
            // Form title
            this.Text = lang.FormTitle;
            
            // Labels
            lblFileName.Text = lang.Filename;
            lblExt.Text = lang.Extension;
            label1.Text = lang.CurrentLocation;
            btnSave.Text = lang.SaveButton;
            lblType.Text = lang.TypeLabel;
            
            // Copyright and website
            lblMe.Text = lang.Copyright;
            lblWebsite.Text = lang.Website;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string location = txtCurrentLocation.Text;
            location = location.EndsWith("\\") ? location : location + "\\";
            string filename = txtFilename.Text + "." + comExt.SelectedItem.ToString();
            if (IsText)
            {

                File.WriteAllText(location + filename, txtContent.Text, Encoding.UTF8);
                this.Text += LanguageManager.Current.FileSaved;
            }
            else
            {
                switch (comExt.SelectedItem.ToString())
                {
                    case "png":
                        imgContent.Image.Save(location + filename, ImageFormat.Png);
                        break;
                    case "ico":
                        imgContent.Image.Save(location + filename, ImageFormat.Icon);
                        break;
                    case "jpg":
                        imgContent.Image.Save(location + filename, ImageFormat.Jpeg);
                        break;
                    case "bmp":
                        imgContent.Image.Save(location + filename, ImageFormat.Bmp);
                        break;
                    case "gif":
                        imgContent.Image.Save(location + filename, ImageFormat.Gif);
                        break;
                    default:
                        imgContent.Image.Save(location + filename, ImageFormat.Png);
                        break;
                }

                this.Text += LanguageManager.Current.ImageSaved;
            }

            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(1000);
                Environment.Exit(0);
            });
        }

        private void btnBrowseForFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = LanguageManager.Current.FolderBrowserDescription;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtCurrentLocation.Text = fbd.SelectedPath;
            }
        }

        private void lblWebsite_Click(object sender, EventArgs e)
        {
            Process.Start("http://eslamx.com");
        }

        private void lblMe_Click(object sender, EventArgs e)
        {
            Process.Start("http://twitter.com/EslaMx7");
        }

        private void lblTranslator_Click(object sender, EventArgs e)
        {
            Process.Start("https://space.bilibili.com/374412219");
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(LanguageManager.Current.HelpMessage, LanguageManager.Current.HelpTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtFilename_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSave_Click(sender, null);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings settingsForm = new frmSettings();
            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                // 重新加载语言设置
                ApplyLocalization();
            }
        }
    }
}
