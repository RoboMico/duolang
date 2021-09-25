
namespace VisualTranslate
{
    partial class FormLogs
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
            this.textBox_logs = new System.Windows.Forms.TextBox();
            this.button_export = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_logs
            // 
            this.textBox_logs.Location = new System.Drawing.Point(12, 12);
            this.textBox_logs.Multiline = true;
            this.textBox_logs.Name = "textBox_logs";
            this.textBox_logs.ReadOnly = true;
            this.textBox_logs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_logs.Size = new System.Drawing.Size(736, 441);
            this.textBox_logs.TabIndex = 0;
            // 
            // button_export
            // 
            this.button_export.Location = new System.Drawing.Point(12, 459);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(103, 28);
            this.button_export.TabIndex = 1;
            this.button_export.Text = "导出日志";
            this.button_export.UseVisualStyleBackColor = true;
            this.button_export.Click += new System.EventHandler(this.button_export_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(121, 459);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(103, 28);
            this.button_clear.TabIndex = 2;
            this.button_clear.Text = "清空日志";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // FormLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 497);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_export);
            this.Controls.Add(this.textBox_logs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogs";
            this.Text = "查看日志";
            this.Load += new System.EventHandler(this.FormLogs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_logs;
        private System.Windows.Forms.Button button_export;
        private System.Windows.Forms.Button button_clear;
    }
}