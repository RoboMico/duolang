
namespace DuoLang
{
    partial class FormSettings
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
            this.components = new System.ComponentModel.Container();
            this.checkBox_ignoreSameValue = new System.Windows.Forms.CheckBox();
            this.textBox_colorTargetUntranslated = new System.Windows.Forms.TextBox();
            this.toolTip_settings = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox_ignoreComments = new System.Windows.Forms.CheckBox();
            this.label_colorTargetUntranslated = new System.Windows.Forms.Label();
            this.linkLabel_checkSources = new System.Windows.Forms.LinkLabel();
            this.groupBox_appearence = new System.Windows.Forms.GroupBox();
            this.groupBox_loading = new System.Windows.Forms.GroupBox();
            this.groupBox_about = new System.Windows.Forms.GroupBox();
            this.label_version = new System.Windows.Forms.Label();
            this.linkLabel_license = new System.Windows.Forms.LinkLabel();
            this.groupBox_appearence.SuspendLayout();
            this.groupBox_loading.SuspendLayout();
            this.groupBox_about.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_ignoreSameValue
            // 
            this.checkBox_ignoreSameValue.AutoSize = true;
            this.checkBox_ignoreSameValue.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_ignoreSameValue.Checked = true;
            this.checkBox_ignoreSameValue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ignoreSameValue.Location = new System.Drawing.Point(6, 22);
            this.checkBox_ignoreSameValue.Name = "checkBox_ignoreSameValue";
            this.checkBox_ignoreSameValue.Size = new System.Drawing.Size(147, 21);
            this.checkBox_ignoreSameValue.TabIndex = 1;
            this.checkBox_ignoreSameValue.Text = "加载时忽略重复翻译值";
            this.toolTip_settings.SetToolTip(this.checkBox_ignoreSameValue, "当目标语言中的翻译与源语言中的一致时，目标语言翻译将被替换为空");
            this.checkBox_ignoreSameValue.UseVisualStyleBackColor = true;
            // 
            // textBox_colorTargetUntranslated
            // 
            this.textBox_colorTargetUntranslated.Location = new System.Drawing.Point(113, 16);
            this.textBox_colorTargetUntranslated.Name = "textBox_colorTargetUntranslated";
            this.textBox_colorTargetUntranslated.Size = new System.Drawing.Size(100, 23);
            this.textBox_colorTargetUntranslated.TabIndex = 5;
            this.textBox_colorTargetUntranslated.Text = "#D5B32B";
            this.textBox_colorTargetUntranslated.DoubleClick += new System.EventHandler(this.textBox_colorTargetUntranslated_DoubleClick);
            // 
            // checkBox_ignoreComments
            // 
            this.checkBox_ignoreComments.AutoSize = true;
            this.checkBox_ignoreComments.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_ignoreComments.Checked = true;
            this.checkBox_ignoreComments.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ignoreComments.Location = new System.Drawing.Point(6, 49);
            this.checkBox_ignoreComments.Name = "checkBox_ignoreComments";
            this.checkBox_ignoreComments.Size = new System.Drawing.Size(191, 21);
            this.checkBox_ignoreComments.TabIndex = 2;
            this.checkBox_ignoreComments.Text = "加载时忽略以“__”开头的翻译键";
            this.toolTip_settings.SetToolTip(this.checkBox_ignoreComments, "以双下划线“__”开头的键通常是作者或其他译者留下的注释");
            this.checkBox_ignoreComments.UseVisualStyleBackColor = true;
            // 
            // label_colorTargetUntranslated
            // 
            this.label_colorTargetUntranslated.AutoSize = true;
            this.label_colorTargetUntranslated.Location = new System.Drawing.Point(6, 19);
            this.label_colorTargetUntranslated.Name = "label_colorTargetUntranslated";
            this.label_colorTargetUntranslated.Size = new System.Drawing.Size(80, 17);
            this.label_colorTargetUntranslated.TabIndex = 6;
            this.label_colorTargetUntranslated.Text = "未翻译键颜色";
            // 
            // linkLabel_checkSources
            // 
            this.linkLabel_checkSources.AutoSize = true;
            this.linkLabel_checkSources.Location = new System.Drawing.Point(6, 69);
            this.linkLabel_checkSources.Name = "linkLabel_checkSources";
            this.linkLabel_checkSources.Size = new System.Drawing.Size(337, 17);
            this.linkLabel_checkSources.TabIndex = 8;
            this.linkLabel_checkSources.TabStop = true;
            this.linkLabel_checkSources.Text = "DuoLang是一款开源软件。欢迎来我们的GitLab开源库康康！";
            this.linkLabel_checkSources.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_checkSources_LinkClicked);
            // 
            // groupBox_appearence
            // 
            this.groupBox_appearence.Controls.Add(this.label_colorTargetUntranslated);
            this.groupBox_appearence.Controls.Add(this.textBox_colorTargetUntranslated);
            this.groupBox_appearence.Location = new System.Drawing.Point(12, 12);
            this.groupBox_appearence.Name = "groupBox_appearence";
            this.groupBox_appearence.Size = new System.Drawing.Size(346, 55);
            this.groupBox_appearence.TabIndex = 10;
            this.groupBox_appearence.TabStop = false;
            this.groupBox_appearence.Text = "外观";
            // 
            // groupBox_loading
            // 
            this.groupBox_loading.Controls.Add(this.checkBox_ignoreSameValue);
            this.groupBox_loading.Controls.Add(this.checkBox_ignoreComments);
            this.groupBox_loading.Location = new System.Drawing.Point(12, 73);
            this.groupBox_loading.Name = "groupBox_loading";
            this.groupBox_loading.Size = new System.Drawing.Size(346, 100);
            this.groupBox_loading.TabIndex = 11;
            this.groupBox_loading.TabStop = false;
            this.groupBox_loading.Text = "加载";
            // 
            // groupBox_about
            // 
            this.groupBox_about.Controls.Add(this.linkLabel_license);
            this.groupBox_about.Controls.Add(this.label_version);
            this.groupBox_about.Controls.Add(this.linkLabel_checkSources);
            this.groupBox_about.Location = new System.Drawing.Point(12, 179);
            this.groupBox_about.Name = "groupBox_about";
            this.groupBox_about.Size = new System.Drawing.Size(346, 100);
            this.groupBox_about.TabIndex = 12;
            this.groupBox_about.TabStop = false;
            this.groupBox_about.Text = "关于";
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.Location = new System.Drawing.Point(6, 19);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(202, 34);
            this.label_version.TabIndex = 0;
            this.label_version.Text = "DuoLang {0} by MineCommander\r\n使用          许可证";
            // 
            // linkLabel_license
            // 
            this.linkLabel_license.AutoSize = true;
            this.linkLabel_license.Location = new System.Drawing.Point(36, 36);
            this.linkLabel_license.Name = "linkLabel_license";
            this.linkLabel_license.Size = new System.Drawing.Size(37, 17);
            this.linkLabel_license.TabIndex = 1;
            this.linkLabel_license.TabStop = true;
            this.linkLabel_license.Text = "ACSL";
            this.linkLabel_license.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_license_LinkClicked);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 297);
            this.Controls.Add(this.groupBox_about);
            this.Controls.Add(this.groupBox_loading);
            this.Controls.Add(this.groupBox_appearence);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.Text = "设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSettings_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormSettings_KeyDown);
            this.groupBox_appearence.ResumeLayout(false);
            this.groupBox_appearence.PerformLayout();
            this.groupBox_loading.ResumeLayout(false);
            this.groupBox_loading.PerformLayout();
            this.groupBox_about.ResumeLayout(false);
            this.groupBox_about.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_ignoreSameValue;
        private System.Windows.Forms.TextBox textBox_colorTargetUntranslated;
        private System.Windows.Forms.ToolTip toolTip_settings;
        private System.Windows.Forms.Label label_colorTargetUntranslated;
        private System.Windows.Forms.LinkLabel linkLabel_checkSources;
        private System.Windows.Forms.CheckBox checkBox_ignoreComments;
        private System.Windows.Forms.GroupBox groupBox_appearence;
        private System.Windows.Forms.GroupBox groupBox_loading;
        private System.Windows.Forms.GroupBox groupBox_about;
        private System.Windows.Forms.LinkLabel linkLabel_license;
        private System.Windows.Forms.Label label_version;
    }
}