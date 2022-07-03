using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuoLang
{
    public partial class FormEditing : Form
    {
        public string lastEditedText;
        public FormEditing(string defaultText)
        {
            InitializeComponent();
            BackColor = ColorTranslator.FromHtml(Runtime.settings.colorSet.background);
            textBox_editing.BackColor = ColorTranslator.FromHtml(Runtime.settings.colorSet.cell);
            textBox_editing.ForeColor = ColorTranslator.FromHtml(Runtime.settings.colorSet.text);
            button_finish.ForeColor = ColorTranslator.FromHtml(Runtime.settings.colorSet.text);
            textBox_editing.Text = defaultText;
            lastEditedText = defaultText;
        }

        private void button_finish_Click(object sender, EventArgs e)
        {
            lastEditedText = textBox_editing.Text;
            this.Close();
        }
    }
}
