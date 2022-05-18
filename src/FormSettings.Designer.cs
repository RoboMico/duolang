
namespace VisualTranslate
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
            this.toolTip_ignoreSameValue = new System.Windows.Forms.ToolTip(this.components);
            this.label_colorTargetUntranslated = new System.Windows.Forms.Label();
            this.radioButton_never = new System.Windows.Forms.RadioButton();
            this.groupBox_basic = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_notEmpty = new System.Windows.Forms.RadioButton();
            this.radioButton_always = new System.Windows.Forms.RadioButton();
            this.label_saveLockedValues = new System.Windows.Forms.Label();
            this.groupBox_colors = new System.Windows.Forms.GroupBox();
            this.linkLabel_checkSources = new System.Windows.Forms.LinkLabel();
            this.groupBox_basic.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox_colors.SuspendLayout();
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
            this.toolTip_ignoreSameValue.SetToolTip(this.checkBox_ignoreSameValue, "当目标语言中的翻译与源语言中的一致时，目标语言翻译将被替换为空");
            this.checkBox_ignoreSameValue.UseVisualStyleBackColor = true;
            // 
            // textBox_colorTargetUntranslated
            // 
            this.textBox_colorTargetUntranslated.Location = new System.Drawing.Point(153, 16);
            this.textBox_colorTargetUntranslated.Name = "textBox_colorTargetUntranslated";
            this.textBox_colorTargetUntranslated.Size = new System.Drawing.Size(100, 23);
            this.textBox_colorTargetUntranslated.TabIndex = 5;
            this.textBox_colorTargetUntranslated.Text = "#D5B32B";
            this.textBox_colorTargetUntranslated.DoubleClick += new System.EventHandler(this.textBox_colorTargetUntranslated_DoubleClick);
            // 
            // label_colorTargetUntranslated
            // 
            this.label_colorTargetUntranslated.AutoSize = true;
            this.label_colorTargetUntranslated.Location = new System.Drawing.Point(6, 19);
            this.label_colorTargetUntranslated.Name = "label_colorTargetUntranslated";
            this.label_colorTargetUntranslated.Size = new System.Drawing.Size(92, 17);
            this.label_colorTargetUntranslated.TabIndex = 6;
            this.label_colorTargetUntranslated.Text = "目标语言未翻译";
            // 
            // radioButton_never
            // 
            this.radioButton_never.AutoSize = true;
            this.radioButton_never.Location = new System.Drawing.Point(7, 20);
            this.radioButton_never.Name = "radioButton_never";
            this.radioButton_never.Size = new System.Drawing.Size(62, 21);
            this.radioButton_never.TabIndex = 2;
            this.radioButton_never.TabStop = true;
            this.radioButton_never.Text = "不保存";
            this.radioButton_never.UseVisualStyleBackColor = true;
            // 
            // groupBox_basic
            // 
            this.groupBox_basic.Controls.Add(this.panel1);
            this.groupBox_basic.Controls.Add(this.checkBox_ignoreSameValue);
            this.groupBox_basic.Location = new System.Drawing.Point(15, 12);
            this.groupBox_basic.Name = "groupBox_basic";
            this.groupBox_basic.Size = new System.Drawing.Size(200, 149);
            this.groupBox_basic.TabIndex = 12;
            this.groupBox_basic.TabStop = false;
            this.groupBox_basic.Text = "基本";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_notEmpty);
            this.panel1.Controls.Add(this.radioButton_always);
            this.panel1.Controls.Add(this.label_saveLockedValues);
            this.panel1.Controls.Add(this.radioButton_never);
            this.panel1.Location = new System.Drawing.Point(6, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(95, 97);
            this.panel1.TabIndex = 14;
            // 
            // radioButton_notEmpty
            // 
            this.radioButton_notEmpty.AutoSize = true;
            this.radioButton_notEmpty.Location = new System.Drawing.Point(7, 47);
            this.radioButton_notEmpty.Name = "radioButton_notEmpty";
            this.radioButton_notEmpty.Size = new System.Drawing.Size(86, 21);
            this.radioButton_notEmpty.TabIndex = 3;
            this.radioButton_notEmpty.TabStop = true;
            this.radioButton_notEmpty.Text = "保存非空值";
            this.radioButton_notEmpty.UseVisualStyleBackColor = true;
            // 
            // radioButton_always
            // 
            this.radioButton_always.AutoSize = true;
            this.radioButton_always.Location = new System.Drawing.Point(7, 74);
            this.radioButton_always.Name = "radioButton_always";
            this.radioButton_always.Size = new System.Drawing.Size(74, 21);
            this.radioButton_always.TabIndex = 4;
            this.radioButton_always.TabStop = true;
            this.radioButton_always.Text = "总是保存";
            this.radioButton_always.UseVisualStyleBackColor = true;
            // 
            // label_saveLockedValues
            // 
            this.label_saveLockedValues.AutoSize = true;
            this.label_saveLockedValues.Location = new System.Drawing.Point(0, 0);
            this.label_saveLockedValues.Name = "label_saveLockedValues";
            this.label_saveLockedValues.Size = new System.Drawing.Size(92, 17);
            this.label_saveLockedValues.TabIndex = 0;
            this.label_saveLockedValues.Text = "保存锁定翻译值";
            // 
            // groupBox_colors
            // 
            this.groupBox_colors.Controls.Add(this.textBox_colorTargetUntranslated);
            this.groupBox_colors.Controls.Add(this.label_colorTargetUntranslated);
            this.groupBox_colors.Location = new System.Drawing.Point(18, 167);
            this.groupBox_colors.Name = "groupBox_colors";
            this.groupBox_colors.Size = new System.Drawing.Size(265, 50);
            this.groupBox_colors.TabIndex = 13;
            this.groupBox_colors.TabStop = false;
            this.groupBox_colors.Text = "颜色";
            // 
            // linkLabel_checkSources
            // 
            this.linkLabel_checkSources.AutoSize = true;
            this.linkLabel_checkSources.Location = new System.Drawing.Point(12, 230);
            this.linkLabel_checkSources.Name = "linkLabel_checkSources";
            this.linkLabel_checkSources.Size = new System.Drawing.Size(372, 17);
            this.linkLabel_checkSources.TabIndex = 8;
            this.linkLabel_checkSources.TabStop = true;
            this.linkLabel_checkSources.Text = "VisualTranslate是一款开源软件。欢迎来我们的GitLab开源库康康！";
            this.linkLabel_checkSources.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_checkSources_LinkClicked);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 257);
            this.Controls.Add(this.linkLabel_checkSources);
            this.Controls.Add(this.groupBox_colors);
            this.Controls.Add(this.groupBox_basic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.Text = "设置";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormSettings_KeyDown);
            this.groupBox_basic.ResumeLayout(false);
            this.groupBox_basic.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox_colors.ResumeLayout(false);
            this.groupBox_colors.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_ignoreSameValue;
        private System.Windows.Forms.TextBox textBox_colorTargetUntranslated;
        private System.Windows.Forms.ToolTip toolTip_ignoreSameValue;
        private System.Windows.Forms.Label label_colorTargetUntranslated;
        private System.Windows.Forms.RadioButton radioButton_never;
        private System.Windows.Forms.GroupBox groupBox_basic;
        private System.Windows.Forms.GroupBox groupBox_colors;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_notEmpty;
        private System.Windows.Forms.RadioButton radioButton_always;
        private System.Windows.Forms.Label label_saveLockedValues;
        private System.Windows.Forms.LinkLabel linkLabel_checkSources;
    }
}