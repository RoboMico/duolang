namespace DuoLang
{
    partial class FormEditing
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
            this.textBox_editing = new System.Windows.Forms.TextBox();
            this.button_finish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_editing
            // 
            this.textBox_editing.AcceptsReturn = true;
            this.textBox_editing.AcceptsTab = true;
            this.textBox_editing.Location = new System.Drawing.Point(12, 12);
            this.textBox_editing.Multiline = true;
            this.textBox_editing.Name = "textBox_editing";
            this.textBox_editing.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_editing.Size = new System.Drawing.Size(411, 243);
            this.textBox_editing.TabIndex = 0;
            // 
            // button_finish
            // 
            this.button_finish.Location = new System.Drawing.Point(348, 265);
            this.button_finish.Name = "button_finish";
            this.button_finish.Size = new System.Drawing.Size(75, 23);
            this.button_finish.TabIndex = 1;
            this.button_finish.Text = "完成";
            this.button_finish.UseVisualStyleBackColor = true;
            this.button_finish.Click += new System.EventHandler(this.button_finish_Click);
            // 
            // FormEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 300);
            this.Controls.Add(this.button_finish);
            this.Controls.Add(this.textBox_editing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormEditing";
            this.Text = "编辑";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_editing;
        private System.Windows.Forms.Button button_finish;
    }
}