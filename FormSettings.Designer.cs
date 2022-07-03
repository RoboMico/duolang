
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
            this.textBox_colorTargetUntranslated = new DuoLang.ColorTextBox();
            this.toolTip_settings = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox_ignoreComments = new System.Windows.Forms.CheckBox();
            this.label_colorTargetUntranslated = new System.Windows.Forms.Label();
            this.linkLabel_checkSources = new System.Windows.Forms.LinkLabel();
            this.linkLabel_license = new System.Windows.Forms.LinkLabel();
            this.label_version = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_behaviour = new System.Windows.Forms.TabPage();
            this.tabPage_appearence = new System.Windows.Forms.TabPage();
            this.label_tip = new System.Windows.Forms.Label();
            this.button_importColorSet = new System.Windows.Forms.Button();
            this.button_exportColorSet = new System.Windows.Forms.Button();
            this.label_colorSelectedText = new System.Windows.Forms.Label();
            this.textBox_colorSelectedText = new DuoLang.ColorTextBox();
            this.label_colorSelectedCell = new System.Windows.Forms.Label();
            this.textBox_colorSelectedCell = new DuoLang.ColorTextBox();
            this.label_colorCellBorder = new System.Windows.Forms.Label();
            this.textBox_colorCellBorder = new DuoLang.ColorTextBox();
            this.label_colorCell = new System.Windows.Forms.Label();
            this.textBox_colorCell = new DuoLang.ColorTextBox();
            this.label_colorText = new System.Windows.Forms.Label();
            this.textBox_colorText = new DuoLang.ColorTextBox();
            this.label_colorBackground = new System.Windows.Forms.Label();
            this.textBox_colorBackground = new DuoLang.ColorTextBox();
            this.tabPage_about = new System.Windows.Forms.TabPage();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.button_reset = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage_behaviour.SuspendLayout();
            this.tabPage_appearence.SuspendLayout();
            this.tabPage_about.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_ignoreSameValue
            // 
            this.checkBox_ignoreSameValue.AutoSize = true;
            this.checkBox_ignoreSameValue.Checked = true;
            this.checkBox_ignoreSameValue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ignoreSameValue.Location = new System.Drawing.Point(6, 6);
            this.checkBox_ignoreSameValue.Name = "checkBox_ignoreSameValue";
            this.checkBox_ignoreSameValue.Size = new System.Drawing.Size(147, 21);
            this.checkBox_ignoreSameValue.TabIndex = 1;
            this.checkBox_ignoreSameValue.Text = "加载时忽略重复翻译值";
            this.toolTip_settings.SetToolTip(this.checkBox_ignoreSameValue, "当目标语言中的翻译与源语言中的一致时，目标语言翻译将被替换为空");
            // 
            // textBox_colorTargetUntranslated
            // 
            this.textBox_colorTargetUntranslated.Location = new System.Drawing.Point(110, 9);
            this.textBox_colorTargetUntranslated.Name = "textBox_colorTargetUntranslated";
            this.textBox_colorTargetUntranslated.Size = new System.Drawing.Size(100, 23);
            this.textBox_colorTargetUntranslated.TabIndex = 5;
            this.textBox_colorTargetUntranslated.Text = "#D5B32B";
            // 
            // checkBox_ignoreComments
            // 
            this.checkBox_ignoreComments.AutoSize = true;
            this.checkBox_ignoreComments.Checked = true;
            this.checkBox_ignoreComments.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ignoreComments.Location = new System.Drawing.Point(6, 33);
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
            this.label_colorTargetUntranslated.Location = new System.Drawing.Point(3, 12);
            this.label_colorTargetUntranslated.Name = "label_colorTargetUntranslated";
            this.label_colorTargetUntranslated.Size = new System.Drawing.Size(80, 17);
            this.label_colorTargetUntranslated.TabIndex = 6;
            this.label_colorTargetUntranslated.Text = "未翻译键颜色";
            // 
            // linkLabel_checkSources
            // 
            this.linkLabel_checkSources.AutoSize = true;
            this.linkLabel_checkSources.Location = new System.Drawing.Point(3, 62);
            this.linkLabel_checkSources.Name = "linkLabel_checkSources";
            this.linkLabel_checkSources.Size = new System.Drawing.Size(337, 17);
            this.linkLabel_checkSources.TabIndex = 8;
            this.linkLabel_checkSources.TabStop = true;
            this.linkLabel_checkSources.Text = "DuoLang是一款开源软件。欢迎来我们的GitLab开源库康康！";
            this.linkLabel_checkSources.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_checkSources_LinkClicked);
            // 
            // linkLabel_license
            // 
            this.linkLabel_license.AutoSize = true;
            this.linkLabel_license.Location = new System.Drawing.Point(33, 29);
            this.linkLabel_license.Name = "linkLabel_license";
            this.linkLabel_license.Size = new System.Drawing.Size(37, 17);
            this.linkLabel_license.TabIndex = 1;
            this.linkLabel_license.TabStop = true;
            this.linkLabel_license.Text = "ACSL";
            this.linkLabel_license.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_license_LinkClicked);
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.Location = new System.Drawing.Point(3, 12);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(202, 34);
            this.label_version.TabIndex = 0;
            this.label_version.Text = "DuoLang {0} by MineCommander\r\n使用          许可证";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_behaviour);
            this.tabControl1.Controls.Add(this.tabPage_appearence);
            this.tabControl1.Controls.Add(this.tabPage_about);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(458, 330);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage_behaviour
            // 
            this.tabPage_behaviour.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_behaviour.Controls.Add(this.checkBox_ignoreSameValue);
            this.tabPage_behaviour.Controls.Add(this.checkBox_ignoreComments);
            this.tabPage_behaviour.Location = new System.Drawing.Point(4, 26);
            this.tabPage_behaviour.Name = "tabPage_behaviour";
            this.tabPage_behaviour.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_behaviour.Size = new System.Drawing.Size(450, 300);
            this.tabPage_behaviour.TabIndex = 0;
            this.tabPage_behaviour.Text = "行为";
            // 
            // tabPage_appearence
            // 
            this.tabPage_appearence.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_appearence.Controls.Add(this.button_reset);
            this.tabPage_appearence.Controls.Add(this.label_tip);
            this.tabPage_appearence.Controls.Add(this.button_importColorSet);
            this.tabPage_appearence.Controls.Add(this.button_exportColorSet);
            this.tabPage_appearence.Controls.Add(this.label_colorSelectedText);
            this.tabPage_appearence.Controls.Add(this.textBox_colorSelectedText);
            this.tabPage_appearence.Controls.Add(this.label_colorSelectedCell);
            this.tabPage_appearence.Controls.Add(this.textBox_colorSelectedCell);
            this.tabPage_appearence.Controls.Add(this.label_colorCellBorder);
            this.tabPage_appearence.Controls.Add(this.textBox_colorCellBorder);
            this.tabPage_appearence.Controls.Add(this.label_colorCell);
            this.tabPage_appearence.Controls.Add(this.textBox_colorCell);
            this.tabPage_appearence.Controls.Add(this.label_colorText);
            this.tabPage_appearence.Controls.Add(this.textBox_colorText);
            this.tabPage_appearence.Controls.Add(this.label_colorBackground);
            this.tabPage_appearence.Controls.Add(this.textBox_colorBackground);
            this.tabPage_appearence.Controls.Add(this.label_colorTargetUntranslated);
            this.tabPage_appearence.Controls.Add(this.textBox_colorTargetUntranslated);
            this.tabPage_appearence.Location = new System.Drawing.Point(4, 26);
            this.tabPage_appearence.Name = "tabPage_appearence";
            this.tabPage_appearence.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_appearence.Size = new System.Drawing.Size(450, 300);
            this.tabPage_appearence.TabIndex = 1;
            this.tabPage_appearence.Text = "外观";
            // 
            // label_tip
            // 
            this.label_tip.AutoSize = true;
            this.label_tip.Location = new System.Drawing.Point(3, 253);
            this.label_tip.Name = "label_tip";
            this.label_tip.Size = new System.Drawing.Size(212, 34);
            this.label_tip.TabIndex = 25;
            this.label_tip.Text = "双击输入框可编辑颜色。\r\n更改颜色设置后需重启应用方可生效。";
            // 
            // button_importColorSet
            // 
            this.button_importColorSet.Location = new System.Drawing.Point(100, 217);
            this.button_importColorSet.Name = "button_importColorSet";
            this.button_importColorSet.Size = new System.Drawing.Size(75, 23);
            this.button_importColorSet.TabIndex = 24;
            this.button_importColorSet.Text = "导入配色";
            this.button_importColorSet.UseVisualStyleBackColor = true;
            this.button_importColorSet.Click += new System.EventHandler(this.button_importColorSet_Click);
            // 
            // button_exportColorSet
            // 
            this.button_exportColorSet.Location = new System.Drawing.Point(9, 217);
            this.button_exportColorSet.Name = "button_exportColorSet";
            this.button_exportColorSet.Size = new System.Drawing.Size(75, 23);
            this.button_exportColorSet.TabIndex = 23;
            this.button_exportColorSet.Text = "导出配色";
            this.button_exportColorSet.UseVisualStyleBackColor = true;
            this.button_exportColorSet.Click += new System.EventHandler(this.button_exportColorSet_Click);
            // 
            // label_colorSelectedText
            // 
            this.label_colorSelectedText.AutoSize = true;
            this.label_colorSelectedText.Location = new System.Drawing.Point(3, 185);
            this.label_colorSelectedText.Name = "label_colorSelectedText";
            this.label_colorSelectedText.Size = new System.Drawing.Size(80, 17);
            this.label_colorSelectedText.TabIndex = 22;
            this.label_colorSelectedText.Text = "选中文字颜色";
            // 
            // textBox_colorSelectedText
            // 
            this.textBox_colorSelectedText.Location = new System.Drawing.Point(110, 182);
            this.textBox_colorSelectedText.Name = "textBox_colorSelectedText";
            this.textBox_colorSelectedText.Size = new System.Drawing.Size(100, 23);
            this.textBox_colorSelectedText.TabIndex = 21;
            this.textBox_colorSelectedText.Text = "#FFFFFF";
            // 
            // label_colorSelectedCell
            // 
            this.label_colorSelectedCell.AutoSize = true;
            this.label_colorSelectedCell.Location = new System.Drawing.Point(3, 97);
            this.label_colorSelectedCell.Name = "label_colorSelectedCell";
            this.label_colorSelectedCell.Size = new System.Drawing.Size(92, 17);
            this.label_colorSelectedCell.TabIndex = 20;
            this.label_colorSelectedCell.Text = "选中单元格颜色";
            // 
            // textBox_colorSelectedCell
            // 
            this.textBox_colorSelectedCell.Location = new System.Drawing.Point(110, 94);
            this.textBox_colorSelectedCell.Name = "textBox_colorSelectedCell";
            this.textBox_colorSelectedCell.Size = new System.Drawing.Size(100, 23);
            this.textBox_colorSelectedCell.TabIndex = 19;
            this.textBox_colorSelectedCell.Text = "#0078D7";
            // 
            // label_colorCellBorder
            // 
            this.label_colorCellBorder.AutoSize = true;
            this.label_colorCellBorder.Location = new System.Drawing.Point(3, 127);
            this.label_colorCellBorder.Name = "label_colorCellBorder";
            this.label_colorCellBorder.Size = new System.Drawing.Size(92, 17);
            this.label_colorCellBorder.TabIndex = 18;
            this.label_colorCellBorder.Text = "单元格边框颜色";
            // 
            // textBox_colorCellBorder
            // 
            this.textBox_colorCellBorder.Location = new System.Drawing.Point(110, 124);
            this.textBox_colorCellBorder.Name = "textBox_colorCellBorder";
            this.textBox_colorCellBorder.Size = new System.Drawing.Size(100, 23);
            this.textBox_colorCellBorder.TabIndex = 17;
            this.textBox_colorCellBorder.Text = "#A0A0A0";
            // 
            // label_colorCell
            // 
            this.label_colorCell.AutoSize = true;
            this.label_colorCell.Location = new System.Drawing.Point(3, 68);
            this.label_colorCell.Name = "label_colorCell";
            this.label_colorCell.Size = new System.Drawing.Size(68, 17);
            this.label_colorCell.TabIndex = 16;
            this.label_colorCell.Text = "单元格颜色";
            // 
            // textBox_colorCell
            // 
            this.textBox_colorCell.Location = new System.Drawing.Point(110, 65);
            this.textBox_colorCell.Name = "textBox_colorCell";
            this.textBox_colorCell.Size = new System.Drawing.Size(100, 23);
            this.textBox_colorCell.TabIndex = 15;
            this.textBox_colorCell.Text = "#FFFFFF";
            // 
            // label_colorText
            // 
            this.label_colorText.AutoSize = true;
            this.label_colorText.Location = new System.Drawing.Point(3, 157);
            this.label_colorText.Name = "label_colorText";
            this.label_colorText.Size = new System.Drawing.Size(56, 17);
            this.label_colorText.TabIndex = 10;
            this.label_colorText.Text = "文字颜色";
            // 
            // textBox_colorText
            // 
            this.textBox_colorText.Location = new System.Drawing.Point(110, 154);
            this.textBox_colorText.Name = "textBox_colorText";
            this.textBox_colorText.Size = new System.Drawing.Size(100, 23);
            this.textBox_colorText.TabIndex = 9;
            this.textBox_colorText.Text = "#000000";
            // 
            // label_colorBackground
            // 
            this.label_colorBackground.AutoSize = true;
            this.label_colorBackground.Location = new System.Drawing.Point(3, 40);
            this.label_colorBackground.Name = "label_colorBackground";
            this.label_colorBackground.Size = new System.Drawing.Size(56, 17);
            this.label_colorBackground.TabIndex = 8;
            this.label_colorBackground.Text = "背景颜色";
            // 
            // textBox_colorBackground
            // 
            this.textBox_colorBackground.Location = new System.Drawing.Point(110, 37);
            this.textBox_colorBackground.Name = "textBox_colorBackground";
            this.textBox_colorBackground.Size = new System.Drawing.Size(100, 23);
            this.textBox_colorBackground.TabIndex = 7;
            this.textBox_colorBackground.Text = "#F0F0F0";
            // 
            // tabPage_about
            // 
            this.tabPage_about.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_about.Controls.Add(this.linkLabel_license);
            this.tabPage_about.Controls.Add(this.label_version);
            this.tabPage_about.Controls.Add(this.linkLabel_checkSources);
            this.tabPage_about.Location = new System.Drawing.Point(4, 26);
            this.tabPage_about.Name = "tabPage_about";
            this.tabPage_about.Size = new System.Drawing.Size(450, 300);
            this.tabPage_about.TabIndex = 2;
            this.tabPage_about.Text = "关于";
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(193, 217);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(84, 23);
            this.button_reset.TabIndex = 26;
            this.button_reset.Text = "重置为默认";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 330);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.Text = "设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSettings_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormSettings_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_behaviour.ResumeLayout(false);
            this.tabPage_behaviour.PerformLayout();
            this.tabPage_appearence.ResumeLayout(false);
            this.tabPage_appearence.PerformLayout();
            this.tabPage_about.ResumeLayout(false);
            this.tabPage_about.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_ignoreSameValue;
        private System.Windows.Forms.ToolTip toolTip_settings;
        private System.Windows.Forms.Label label_colorTargetUntranslated;
        private System.Windows.Forms.LinkLabel linkLabel_checkSources;
        private System.Windows.Forms.CheckBox checkBox_ignoreComments;
        private System.Windows.Forms.LinkLabel linkLabel_license;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_behaviour;
        private System.Windows.Forms.TabPage tabPage_appearence;
        private System.Windows.Forms.TabPage tabPage_about;
        private System.Windows.Forms.Label label_colorBackground;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label_colorText;
        private System.Windows.Forms.Label label_colorCell;
        private System.Windows.Forms.Label label_colorCellBorder;
        private System.Windows.Forms.Label label_colorSelectedCell;
        private System.Windows.Forms.Label label_colorSelectedText;
        private ColorTextBox textBox_colorTargetUntranslated;
        private ColorTextBox textBox_colorBackground;
        private ColorTextBox textBox_colorText;
        private ColorTextBox textBox_colorCell;
        private ColorTextBox textBox_colorCellBorder;
        private ColorTextBox textBox_colorSelectedCell;
        private ColorTextBox textBox_colorSelectedText;
        private System.Windows.Forms.Button button_importColorSet;
        private System.Windows.Forms.Button button_exportColorSet;
        private System.Windows.Forms.Label label_tip;
        private System.Windows.Forms.Button button_reset;
    }
}