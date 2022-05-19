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
