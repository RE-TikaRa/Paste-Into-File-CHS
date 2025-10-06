namespace PasteAsFile
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.grpLanguage = new System.Windows.Forms.GroupBox();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.grpFilename = new System.Windows.Forms.GroupBox();
            this.lblPreviewValue = new System.Windows.Forms.Label();
            this.lblFilenamePreview = new System.Windows.Forms.Label();
            this.txtFilenameFormat = new System.Windows.Forms.TextBox();
            this.lblFilenameFormat = new System.Windows.Forms.Label();
            this.grpContextMenu = new System.Windows.Forms.GroupBox();
            this.lblRegistrationStatus = new System.Windows.Forms.Label();
            this.btnUnregister = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpLanguage.SuspendLayout();
            this.grpFilename.SuspendLayout();
            this.grpContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLanguage
            // 
            this.grpLanguage.Controls.Add(this.cmbLanguage);
            this.grpLanguage.Controls.Add(this.lblLanguage);
            this.grpLanguage.Location = new System.Drawing.Point(12, 12);
            this.grpLanguage.Name = "grpLanguage";
            this.grpLanguage.Size = new System.Drawing.Size(460, 80);
            this.grpLanguage.TabIndex = 0;
            this.grpLanguage.TabStop = false;
            this.grpLanguage.Text = "Language / 语言";
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(20, 45);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(420, 24);
            this.cmbLanguage.TabIndex = 1;
            this.cmbLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbLanguage_SelectedIndexChanged);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(17, 25);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(155, 13);
            this.lblLanguage.TabIndex = 0;
            this.lblLanguage.Text = "Select Language / 选择语言 :";
            // 
            // grpFilename
            // 
            this.grpFilename.Controls.Add(this.lblPreviewValue);
            this.grpFilename.Controls.Add(this.lblFilenamePreview);
            this.grpFilename.Controls.Add(this.txtFilenameFormat);
            this.grpFilename.Controls.Add(this.lblFilenameFormat);
            this.grpFilename.Location = new System.Drawing.Point(12, 98);
            this.grpFilename.Name = "grpFilename";
            this.grpFilename.Size = new System.Drawing.Size(460, 110);
            this.grpFilename.TabIndex = 1;
            this.grpFilename.TabStop = false;
            this.grpFilename.Text = "Filename Format / 文件名格式";
            // 
            // lblPreviewValue
            // 
            this.lblPreviewValue.AutoSize = true;
            this.lblPreviewValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblPreviewValue.ForeColor = System.Drawing.Color.Green;
            this.lblPreviewValue.Location = new System.Drawing.Point(17, 80);
            this.lblPreviewValue.Name = "lblPreviewValue";
            this.lblPreviewValue.Size = new System.Drawing.Size(159, 15);
            this.lblPreviewValue.TabIndex = 3;
            this.lblPreviewValue.Text = "2025-10-06 14.30.25.txt";
            // 
            // lblFilenamePreview
            // 
            this.lblFilenamePreview.AutoSize = true;
            this.lblFilenamePreview.Location = new System.Drawing.Point(17, 60);
            this.lblFilenamePreview.Name = "lblFilenamePreview";
            this.lblFilenamePreview.Size = new System.Drawing.Size(107, 13);
            this.lblFilenamePreview.TabIndex = 2;
            this.lblFilenamePreview.Text = "Preview / 预览效果 :";
            // 
            // txtFilenameFormat
            // 
            this.txtFilenameFormat.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtFilenameFormat.Location = new System.Drawing.Point(20, 35);
            this.txtFilenameFormat.Name = "txtFilenameFormat";
            this.txtFilenameFormat.Size = new System.Drawing.Size(420, 23);
            this.txtFilenameFormat.TabIndex = 1;
            this.txtFilenameFormat.Text = "yyyy-MM-dd HH.mm.ss";
            this.txtFilenameFormat.TextChanged += new System.EventHandler(this.txtFilenameFormat_TextChanged);
            // 
            // lblFilenameFormat
            // 
            this.lblFilenameFormat.AutoSize = true;
            this.lblFilenameFormat.Location = new System.Drawing.Point(17, 19);
            this.lblFilenameFormat.Name = "lblFilenameFormat";
            this.lblFilenameFormat.Size = new System.Drawing.Size(300, 13);
            this.lblFilenameFormat.TabIndex = 0;
            this.lblFilenameFormat.Text = "Format (yyyy-MM-dd HH.mm.ss) / 格式 (yyyy年MM月dd日) :";
            // 
            // grpContextMenu
            // 
            this.grpContextMenu.Controls.Add(this.lblRegistrationStatus);
            this.grpContextMenu.Controls.Add(this.btnUnregister);
            this.grpContextMenu.Controls.Add(this.btnRegister);
            this.grpContextMenu.Location = new System.Drawing.Point(12, 214);
            this.grpContextMenu.Name = "grpContextMenu";
            this.grpContextMenu.Size = new System.Drawing.Size(460, 100);
            this.grpContextMenu.TabIndex = 2;
            this.grpContextMenu.TabStop = false;
            this.grpContextMenu.Text = "Context Menu / 右键菜单";
            // 
            // lblRegistrationStatus
            // 
            this.lblRegistrationStatus.AutoSize = true;
            this.lblRegistrationStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblRegistrationStatus.ForeColor = System.Drawing.Color.Green;
            this.lblRegistrationStatus.Location = new System.Drawing.Point(17, 25);
            this.lblRegistrationStatus.Name = "lblRegistrationStatus";
            this.lblRegistrationStatus.Size = new System.Drawing.Size(75, 15);
            this.lblRegistrationStatus.TabIndex = 2;
            this.lblRegistrationStatus.Text = "Registered";
            // 
            // btnUnregister
            // 
            this.btnUnregister.Location = new System.Drawing.Point(237, 55);
            this.btnUnregister.Name = "btnUnregister";
            this.btnUnregister.Size = new System.Drawing.Size(200, 30);
            this.btnUnregister.TabIndex = 1;
            this.btnUnregister.Text = "Unregister / 注销";
            this.btnUnregister.UseVisualStyleBackColor = true;
            this.btnUnregister.Click += new System.EventHandler(this.btnUnregister_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(20, 55);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(200, 30);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register / 注册";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(249, 330);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 35);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save / 保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(365, 330);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 35);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel / 取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 377);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpContextMenu);
            this.Controls.Add(this.grpFilename);
            this.Controls.Add(this.grpLanguage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings / 设置";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.grpLanguage.ResumeLayout(false);
            this.grpLanguage.PerformLayout();
            this.grpFilename.ResumeLayout(false);
            this.grpFilename.PerformLayout();
            this.grpContextMenu.ResumeLayout(false);
            this.grpContextMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLanguage;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.GroupBox grpFilename;
        private System.Windows.Forms.TextBox txtFilenameFormat;
        private System.Windows.Forms.Label lblFilenameFormat;
        private System.Windows.Forms.Label lblPreviewValue;
        private System.Windows.Forms.Label lblFilenamePreview;
        private System.Windows.Forms.GroupBox grpContextMenu;
        private System.Windows.Forms.Button btnUnregister;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblRegistrationStatus;
    }
}
