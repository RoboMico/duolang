using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualTranslate
{
    public partial class FormLogs : Form
    {
        public FormLogs()
        {
            InitializeComponent();
        }

        private void FormLogs_Load(object sender, EventArgs e)
        {
            textBox_logs.Lines = Settings.logs.ToString().Split('\n');
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            Settings.logs.Clear();
            textBox_logs.Lines = Array.Empty<string>();
        }

        private void button_export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new();
            saveFileDialog.FileName = DateTime.Now.ToString("yyyy-MM-dd_HHmmss") + ".log";
            saveFileDialog.DefaultExt = "log";
            saveFileDialog.ShowDialog();

        }
    }
}
