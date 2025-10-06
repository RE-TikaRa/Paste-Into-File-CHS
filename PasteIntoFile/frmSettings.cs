using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasteAsFile.Localization;

namespace PasteAsFile
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            // 应用本地化
            ApplyLocalization();

            // 加载当前设置
            LoadSettings();
        }

        private void ApplyLocalization()
        {
            var lang = LanguageManager.Current;
            
            this.Text = lang.SettingsTitle;
            grpLanguage.Text = lang.LanguageGroup;
            lblLanguage.Text = lang.SelectLanguage;
            grpFilename.Text = lang.FilenameGroup;
            lblFilenameFormat.Text = lang.FilenameFormat;
            lblFilenamePreview.Text = lang.FilenamePreview;
            grpContextMenu.Text = lang.ContextMenuGroup;
            btnRegister.Text = lang.RegisterButton;
            btnUnregister.Text = lang.UnregisterButton;
            btnSave.Text = lang.SaveButton;
            btnCancel.Text = lang.CancelButton;
            
            // 设置语言下拉菜单项
            cmbLanguage.Items.Clear();
            cmbLanguage.Items.Add(new LanguageItem("en", "English"));
            cmbLanguage.Items.Add(new LanguageItem("zh", "简体中文 (Simplified Chinese)"));
        }

        private void LoadSettings()
        {
            // 加载语言设置
            string currentLang = GetCurrentLanguageCode();
            for (int i = 0; i < cmbLanguage.Items.Count; i++)
            {
                var item = (LanguageItem)cmbLanguage.Items[i];
                if (item.Code == currentLang)
                {
                    cmbLanguage.SelectedIndex = i;
                    break;
                }
            }

            // 加载文件名格式
            string filenameFormat = (string)Registry.GetValue(
                @"HKEY_CURRENT_USER\Software\Classes\Directory\shell\Paste Into File\filename", 
                "", 
                frmMain.DEFAULT_FILENAME_FORMAT) ?? frmMain.DEFAULT_FILENAME_FORMAT;
            txtFilenameFormat.Text = filenameFormat;

            // 更新预览
            UpdateFilenamePreview();

            // 检查是否已注册
            UpdateRegistrationStatus();
        }

        private string GetCurrentLanguageCode()
        {
            string savedLanguage = (string)Registry.GetValue(
                @"HKEY_CURRENT_USER\Software\Classes\Directory\shell\Paste Into File\language", 
                "", 
                null);

            if (!string.IsNullOrEmpty(savedLanguage))
            {
                return savedLanguage;
            }

            // 返回默认语言
            var culture = System.Globalization.CultureInfo.CurrentUICulture;
            if (culture.TwoLetterISOLanguageName == "zh" || culture.Name.StartsWith("zh"))
            {
                return "zh";
            }
            return "en";
        }

        private void UpdateFilenamePreview()
        {
            try
            {
                string preview = DateTime.Now.ToString(txtFilenameFormat.Text);
                lblPreviewValue.Text = preview + ".txt";
                lblPreviewValue.ForeColor = Color.Green;
            }
            catch
            {
                lblPreviewValue.Text = LanguageManager.Current.InvalidFormat;
                lblPreviewValue.ForeColor = Color.Red;
            }
        }

        private void UpdateRegistrationStatus()
        {
            bool isRegistered = Registry.GetValue(
                @"HKEY_CURRENT_USER\Software\Classes\Directory\Background\shell\Paste Into File\command", 
                "", 
                null) != null;

            if (isRegistered)
            {
                lblRegistrationStatus.Text = LanguageManager.Current.RegistrationStatusRegistered;
                lblRegistrationStatus.ForeColor = Color.Green;
                btnRegister.Enabled = false;
                btnUnregister.Enabled = true;
            }
            else
            {
                lblRegistrationStatus.Text = LanguageManager.Current.RegistrationStatusNotRegistered;
                lblRegistrationStatus.ForeColor = Color.Red;
                btnRegister.Enabled = true;
                btnUnregister.Enabled = false;
            }
        }

        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLanguage.SelectedItem != null)
            {
                var item = (LanguageItem)cmbLanguage.SelectedItem;
                // 立即应用语言
                LanguageManager.SetLanguage(item.Code);
                ApplyLocalization();
                UpdateFilenamePreview();
                UpdateRegistrationStatus();
            }
        }

        private void txtFilenameFormat_TextChanged(object sender, EventArgs e)
        {
            UpdateFilenamePreview();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Program.RegisterApp();
            UpdateRegistrationStatus();
        }

        private void btnUnregister_Click(object sender, EventArgs e)
        {
            Program.UnRegisterApp();
            UpdateRegistrationStatus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // 保存语言设置
                if (cmbLanguage.SelectedItem != null)
                {
                    var item = (LanguageItem)cmbLanguage.SelectedItem;
                    LanguageManager.SaveLanguagePreference(item.Code);
                }

                // 保存文件名格式
                Program.RegisterFilename(txtFilenameFormat.Text);

                MessageBox.Show(
                    LanguageManager.Current.SettingsSaved, 
                    LanguageManager.Current.SettingsTitle, 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message + LanguageManager.Current.ErrorAdminRequired, 
                    LanguageManager.Current.ErrorTitle, 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // 辅助类用于语言下拉列表
        private class LanguageItem
        {
            public string Code { get; set; }
            public string DisplayName { get; set; }

            public LanguageItem(string code, string displayName)
            {
                Code = code;
                DisplayName = displayName;
            }

            public override string ToString()
            {
                return DisplayName;
            }
        }
    }
}
