
namespace VisualTranslate
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOriginalLanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTargetLanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLocked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button_loadOriginalLanguage = new System.Windows.Forms.Button();
            this.button_loadTargetLanguage = new System.Windows.Forms.Button();
            this.label_originalLanguage = new System.Windows.Forms.Label();
            this.label_targetLanguage = new System.Windows.Forms.Label();
            this.button_log = new System.Windows.Forms.Button();
            this.button_settings = new System.Windows.Forms.Button();
            this.button_saveAs = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label_keyCount = new System.Windows.Forms.Label();
            this.label_saved = new System.Windows.Forms.Label();
            this.label_untranslatedCount = new System.Windows.Forms.Label();
            this.button_reload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnKey,
            this.ColumnOriginalLanguage,
            this.ColumnTargetLanguage,
            this.ColumnLocked});
            this.dataGridView1.Location = new System.Drawing.Point(12, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(944, 524);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
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
            this.ColumnTargetLanguage.Width = 250;
            // 
            // ColumnLocked
            // 
            this.ColumnLocked.HeaderText = "锁定";
            this.ColumnLocked.Name = "ColumnLocked";
            this.ColumnLocked.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnLocked.Width = 50;
            // 
            // button_loadOriginalLanguage
            // 
            this.button_loadOriginalLanguage.Location = new System.Drawing.Point(12, 19);
            this.button_loadOriginalLanguage.Name = "button_loadOriginalLanguage";
            this.button_loadOriginalLanguage.Size = new System.Drawing.Size(100, 28);
            this.button_loadOriginalLanguage.TabIndex = 1;
            this.button_loadOriginalLanguage.Text = "加载源语言";
            this.button_loadOriginalLanguage.UseVisualStyleBackColor = true;
            this.button_loadOriginalLanguage.Click += new System.EventHandler(this.button_loadOriginalLanguage_Click);
            // 
            // button_loadTargetLanguage
            // 
            this.button_loadTargetLanguage.Location = new System.Drawing.Point(12, 53);
            this.button_loadTargetLanguage.Name = "button_loadTargetLanguage";
            this.button_loadTargetLanguage.Size = new System.Drawing.Size(100, 28);
            this.button_loadTargetLanguage.TabIndex = 2;
            this.button_loadTargetLanguage.Text = "加载目标语言";
            this.button_loadTargetLanguage.UseVisualStyleBackColor = true;
            this.button_loadTargetLanguage.Click += new System.EventHandler(this.button_loadTargetLanguage_Click);
            // 
            // label_originalLanguage
            // 
            this.label_originalLanguage.AutoSize = true;
            this.label_originalLanguage.Location = new System.Drawing.Point(118, 25);
            this.label_originalLanguage.Name = "label_originalLanguage";
            this.label_originalLanguage.Size = new System.Drawing.Size(44, 17);
            this.label_originalLanguage.TabIndex = 3;
            this.label_originalLanguage.Text = "未加载";
            // 
            // label_targetLanguage
            // 
            this.label_targetLanguage.AutoSize = true;
            this.label_targetLanguage.Location = new System.Drawing.Point(118, 59);
            this.label_targetLanguage.Name = "label_targetLanguage";
            this.label_targetLanguage.Size = new System.Drawing.Size(44, 17);
            this.label_targetLanguage.TabIndex = 4;
            this.label_targetLanguage.Text = "未加载";
            // 
            // button_log
            // 
            this.button_log.Location = new System.Drawing.Point(856, 53);
            this.button_log.Name = "button_log";
            this.button_log.Size = new System.Drawing.Size(100, 28);
            this.button_log.TabIndex = 5;
            this.button_log.Text = "日志";
            this.button_log.UseVisualStyleBackColor = true;
            this.button_log.Click += new System.EventHandler(this.button_log_Click);
            // 
            // button_settings
            // 
            this.button_settings.Location = new System.Drawing.Point(856, 19);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(100, 28);
            this.button_settings.TabIndex = 6;
            this.button_settings.Text = "设置";
            this.button_settings.UseVisualStyleBackColor = true;
            this.button_settings.Click += new System.EventHandler(this.button_settings_Click);
            // 
            // button_saveAs
            // 
            this.button_saveAs.Location = new System.Drawing.Point(750, 53);
            this.button_saveAs.Name = "button_saveAs";
            this.button_saveAs.Size = new System.Drawing.Size(100, 28);
            this.button_saveAs.TabIndex = 7;
            this.button_saveAs.Text = "另存为";
            this.button_saveAs.UseVisualStyleBackColor = true;
            this.button_saveAs.Click += new System.EventHandler(this.button_saveAs_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(750, 19);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(100, 28);
            this.button_save.TabIndex = 8;
            this.button_save.Text = "保存";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label_keyCount
            // 
            this.label_keyCount.AutoSize = true;
            this.label_keyCount.Location = new System.Drawing.Point(13, 644);
            this.label_keyCount.Name = "label_keyCount";
            this.label_keyCount.Size = new System.Drawing.Size(75, 17);
            this.label_keyCount.TabIndex = 9;
            this.label_keyCount.Text = "翻译键数量: ";
            // 
            // label_saved
            // 
            this.label_saved.AutoSize = true;
            this.label_saved.Location = new System.Drawing.Point(912, 644);
            this.label_saved.Name = "label_saved";
            this.label_saved.Size = new System.Drawing.Size(44, 17);
            this.label_saved.TabIndex = 10;
            this.label_saved.Text = "已保存";
            this.label_saved.Visible = false;
            // 
            // label_untranslatedCount
            // 
            this.label_untranslatedCount.AutoSize = true;
            this.label_untranslatedCount.Location = new System.Drawing.Point(287, 644);
            this.label_untranslatedCount.Name = "label_untranslatedCount";
            this.label_untranslatedCount.Size = new System.Drawing.Size(75, 17);
            this.label_untranslatedCount.TabIndex = 11;
            this.label_untranslatedCount.Text = "未翻译数量: ";
            // 
            // button_reload
            // 
            this.button_reload.Location = new System.Drawing.Point(644, 19);
            this.button_reload.Name = "button_reload";
            this.button_reload.Size = new System.Drawing.Size(100, 28);
            this.button_reload.TabIndex = 12;
            this.button_reload.Text = "重新加载";
            this.button_reload.UseVisualStyleBackColor = true;
            this.button_reload.Click += new System.EventHandler(this.button_reload_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 674);
            this.Controls.Add(this.button_reload);
            this.Controls.Add(this.label_untranslatedCount);
            this.Controls.Add(this.label_saved);
            this.Controls.Add(this.label_keyCount);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_saveAs);
            this.Controls.Add(this.button_settings);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_log);
            this.Controls.Add(this.label_targetLanguage);
            this.Controls.Add(this.label_originalLanguage);
            this.Controls.Add(this.button_loadTargetLanguage);
            this.Controls.Add(this.button_loadOriginalLanguage);
            this.KeyPreview = true;
            this.Name = "FormMain";
            this.Text = "VisualTranslate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
            this.DoubleClick += new System.EventHandler(this.FormMain_DoubleClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_loadOriginalLanguage;
        private System.Windows.Forms.Button button_loadTargetLanguage;
        private System.Windows.Forms.Label label_originalLanguage;
        private System.Windows.Forms.Label label_targetLanguage;
        private System.Windows.Forms.Button button_log;
        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.Button button_saveAs;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOriginalLanguage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTargetLanguage;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnLocked;
        private System.Windows.Forms.Label label_keyCount;
        private System.Windows.Forms.Label label_saved;
        private System.Windows.Forms.Label label_untranslatedCount;
        private System.Windows.Forms.Button button_reload;
    }
}

