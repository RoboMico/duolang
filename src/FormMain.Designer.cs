
namespace DuoLang
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_main = new System.Windows.Forms.DataGridView();
            this.ColumnKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOriginalLanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTargetLanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip_main = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_file = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_loadSourceLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_loadTargetLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_reload = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_saveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_settings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_openLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip_main = new System.Windows.Forms.StatusStrip();
            this.statusStripStatusLabel_totalKeys = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripStatusLabel_placeTaker = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripStatusLabel_translated = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripStatusLabel_saved = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripStatusLabel_progress = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripProgressBar_progress = new System.Windows.Forms.ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_main)).BeginInit();
            this.menuStrip_main.SuspendLayout();
            this.statusStrip_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_main
            // 
            this.dataGridView_main.AllowUserToAddRows = false;
            this.dataGridView_main.AllowUserToDeleteRows = false;
            this.dataGridView_main.AllowUserToOrderColumns = true;
            this.dataGridView_main.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_main.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnKey,
            this.ColumnOriginalLanguage,
            this.ColumnTargetLanguage});
            this.dataGridView_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_main.EnableHeadersVisualStyles = false;
            this.dataGridView_main.Location = new System.Drawing.Point(0, 25);
            this.dataGridView_main.Name = "dataGridView_main";
            this.dataGridView_main.ReadOnly = true;
            this.dataGridView_main.RowTemplate.Height = 25;
            this.dataGridView_main.Size = new System.Drawing.Size(968, 649);
            this.dataGridView_main.TabIndex = 0;
            this.dataGridView_main.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_main_CellMouseDoubleClick);
            // 
            // ColumnKey
            // 
            this.ColumnKey.HeaderText = "键";
            this.ColumnKey.Name = "ColumnKey";
            this.ColumnKey.ReadOnly = true;
            this.ColumnKey.Width = 350;
            // 
            // ColumnOriginalLanguage
            // 
            this.ColumnOriginalLanguage.HeaderText = "源语言";
            this.ColumnOriginalLanguage.Name = "ColumnOriginalLanguage";
            this.ColumnOriginalLanguage.ReadOnly = true;
            this.ColumnOriginalLanguage.Width = 250;
            // 
            // ColumnTargetLanguage
            // 
            this.ColumnTargetLanguage.HeaderText = "目标语言";
            this.ColumnTargetLanguage.Name = "ColumnTargetLanguage";
            this.ColumnTargetLanguage.ReadOnly = true;
            this.ColumnTargetLanguage.Width = 250;
            // 
            // menuStrip_main
            // 
            this.menuStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_file,
            this.toolStripMenuItem_edit,
            this.toolStripMenuItem_tool});
            this.menuStrip_main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_main.Name = "menuStrip_main";
            this.menuStrip_main.Size = new System.Drawing.Size(968, 25);
            this.menuStrip_main.TabIndex = 13;
            this.menuStrip_main.Text = "menuStrip1";
            // 
            // toolStripMenuItem_file
            // 
            this.toolStripMenuItem_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_loadSourceLanguage,
            this.toolStripMenuItem_loadTargetLanguage,
            this.toolStripMenuItem_reload,
            this.toolStripMenuItem_save,
            this.toolStripMenuItem_saveAs});
            this.toolStripMenuItem_file.Name = "toolStripMenuItem_file";
            this.toolStripMenuItem_file.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItem_file.Text = "文件";
            // 
            // toolStripMenuItem_loadSourceLanguage
            // 
            this.toolStripMenuItem_loadSourceLanguage.Name = "toolStripMenuItem_loadSourceLanguage";
            this.toolStripMenuItem_loadSourceLanguage.ShortcutKeyDisplayString = "Ctrl+I";
            this.toolStripMenuItem_loadSourceLanguage.Size = new System.Drawing.Size(195, 22);
            this.toolStripMenuItem_loadSourceLanguage.Text = "加载源语言";
            this.toolStripMenuItem_loadSourceLanguage.Click += new System.EventHandler(this.toolStripMenuItem_loadSourceLanguage_Click);
            // 
            // toolStripMenuItem_loadTargetLanguage
            // 
            this.toolStripMenuItem_loadTargetLanguage.Name = "toolStripMenuItem_loadTargetLanguage";
            this.toolStripMenuItem_loadTargetLanguage.ShortcutKeyDisplayString = "Ctrl+O";
            this.toolStripMenuItem_loadTargetLanguage.Size = new System.Drawing.Size(195, 22);
            this.toolStripMenuItem_loadTargetLanguage.Text = "加载目标语言";
            this.toolStripMenuItem_loadTargetLanguage.Click += new System.EventHandler(this.toolStripMenuItem_loadTargetLanguage_Click);
            // 
            // toolStripMenuItem_reload
            // 
            this.toolStripMenuItem_reload.Name = "toolStripMenuItem_reload";
            this.toolStripMenuItem_reload.ShortcutKeyDisplayString = "Ctrl+R";
            this.toolStripMenuItem_reload.Size = new System.Drawing.Size(195, 22);
            this.toolStripMenuItem_reload.Text = "重新加载";
            this.toolStripMenuItem_reload.Click += new System.EventHandler(this.toolStripMenuItem_reload_Click);
            // 
            // toolStripMenuItem_save
            // 
            this.toolStripMenuItem_save.Name = "toolStripMenuItem_save";
            this.toolStripMenuItem_save.ShortcutKeyDisplayString = "Ctrl+S";
            this.toolStripMenuItem_save.Size = new System.Drawing.Size(195, 22);
            this.toolStripMenuItem_save.Text = "保存";
            this.toolStripMenuItem_save.Click += new System.EventHandler(this.toolStripMenuItem_save_Click);
            // 
            // toolStripMenuItem_saveAs
            // 
            this.toolStripMenuItem_saveAs.Name = "toolStripMenuItem_saveAs";
            this.toolStripMenuItem_saveAs.ShortcutKeyDisplayString = "Ctrl+Shift+S";
            this.toolStripMenuItem_saveAs.Size = new System.Drawing.Size(195, 22);
            this.toolStripMenuItem_saveAs.Text = "另存为";
            this.toolStripMenuItem_saveAs.Click += new System.EventHandler(this.toolStripMenuItem_saveAs_Click);
            // 
            // toolStripMenuItem_edit
            // 
            this.toolStripMenuItem_edit.Name = "toolStripMenuItem_edit";
            this.toolStripMenuItem_edit.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItem_edit.Text = "编辑";
            // 
            // toolStripMenuItem_tool
            // 
            this.toolStripMenuItem_tool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_settings,
            this.toolStripMenuItem_openLogs});
            this.toolStripMenuItem_tool.Name = "toolStripMenuItem_tool";
            this.toolStripMenuItem_tool.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItem_tool.Text = "工具";
            // 
            // toolStripMenuItem_settings
            // 
            this.toolStripMenuItem_settings.Name = "toolStripMenuItem_settings";
            this.toolStripMenuItem_settings.ShortcutKeyDisplayString = "Ctrl+,";
            this.toolStripMenuItem_settings.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuItem_settings.Text = "设置";
            this.toolStripMenuItem_settings.Click += new System.EventHandler(this.toolStripMenuItem_settings_Click);
            // 
            // toolStripMenuItem_openLogs
            // 
            this.toolStripMenuItem_openLogs.Name = "toolStripMenuItem_openLogs";
            this.toolStripMenuItem_openLogs.ShortcutKeyDisplayString = "Ctrl+L";
            this.toolStripMenuItem_openLogs.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuItem_openLogs.Text = "查看日志";
            this.toolStripMenuItem_openLogs.Click += new System.EventHandler(this.toolStripMenuItem_openLogs_Click);
            // 
            // statusStrip_main
            // 
            this.statusStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripStatusLabel_totalKeys,
            this.statusStripStatusLabel_placeTaker,
            this.statusStripStatusLabel_translated,
            this.toolStripStatusLabel1,
            this.statusStripStatusLabel_saved,
            this.statusStripStatusLabel_progress,
            this.statusStripProgressBar_progress});
            this.statusStrip_main.Location = new System.Drawing.Point(0, 652);
            this.statusStrip_main.Name = "statusStrip_main";
            this.statusStrip_main.Size = new System.Drawing.Size(968, 22);
            this.statusStrip_main.TabIndex = 14;
            this.statusStrip_main.Text = "statusStrip1";
            // 
            // statusStripStatusLabel_totalKeys
            // 
            this.statusStripStatusLabel_totalKeys.Name = "statusStripStatusLabel_totalKeys";
            this.statusStripStatusLabel_totalKeys.Size = new System.Drawing.Size(80, 17);
            this.statusStripStatusLabel_totalKeys.Text = "翻译键数量：";
            // 
            // statusStripStatusLabel_placeTaker
            // 
            this.statusStripStatusLabel_placeTaker.Name = "statusStripStatusLabel_placeTaker";
            this.statusStripStatusLabel_placeTaker.Size = new System.Drawing.Size(24, 17);
            this.statusStripStatusLabel_placeTaker.Text = "    ";
            // 
            // statusStripStatusLabel_translated
            // 
            this.statusStripStatusLabel_translated.Name = "statusStripStatusLabel_translated";
            this.statusStripStatusLabel_translated.Size = new System.Drawing.Size(56, 17);
            this.statusStripStatusLabel_translated.Text = "已翻译：";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(595, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "    ";
            // 
            // statusStripStatusLabel_saved
            // 
            this.statusStripStatusLabel_saved.Name = "statusStripStatusLabel_saved";
            this.statusStripStatusLabel_saved.Size = new System.Drawing.Size(44, 17);
            this.statusStripStatusLabel_saved.Text = "已保存";
            this.statusStripStatusLabel_saved.Visible = false;
            // 
            // statusStripStatusLabel_progress
            // 
            this.statusStripStatusLabel_progress.Name = "statusStripStatusLabel_progress";
            this.statusStripStatusLabel_progress.Size = new System.Drawing.Size(96, 17);
            this.statusStripStatusLabel_progress.Text = "翻译进度：0.0%";
            // 
            // statusStripProgressBar_progress
            // 
            this.statusStripProgressBar_progress.Name = "statusStripProgressBar_progress";
            this.statusStripProgressBar_progress.Size = new System.Drawing.Size(100, 16);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 674);
            this.Controls.Add(this.statusStrip_main);
            this.Controls.Add(this.dataGridView_main);
            this.Controls.Add(this.menuStrip_main);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip_main;
            this.Name = "FormMain";
            this.Text = "DuoLang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.DoubleClick += new System.EventHandler(this.FormMain_DoubleClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_main)).EndInit();
            this.menuStrip_main.ResumeLayout(false);
            this.menuStrip_main.PerformLayout();
            this.statusStrip_main.ResumeLayout(false);
            this.statusStrip_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_main;
        private System.Windows.Forms.MenuStrip menuStrip_main;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_file;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_loadSourceLanguage;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_loadTargetLanguage;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_reload;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_save;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_saveAs;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_edit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_tool;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_settings;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_openLogs;
        private System.Windows.Forms.StatusStrip statusStrip_main;
        private System.Windows.Forms.ToolStripStatusLabel statusStripStatusLabel_totalKeys;
        private System.Windows.Forms.ToolStripStatusLabel statusStripStatusLabel_translated;
        private System.Windows.Forms.ToolStripStatusLabel statusStripStatusLabel_placeTaker;
        private System.Windows.Forms.ToolStripProgressBar statusStripProgressBar_progress;
        private System.Windows.Forms.ToolStripStatusLabel statusStripStatusLabel_saved;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOriginalLanguage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTargetLanguage;
        private System.Windows.Forms.ToolStripStatusLabel statusStripStatusLabel_progress;
    }
}

