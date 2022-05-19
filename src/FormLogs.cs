using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuoLang
{
    public partial class FormLogs : Form
    {
        public FormLogs()
        {
            InitializeComponent();
        }

        private void FormLogs_Load(object sender, EventArgs e)
        {
            textBox_logs.Lines = Runtime.logs.ToString().Split('\n');
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            Runtime.logs.Clear();
            textBox_logs.Lines = Array.Empty<string>();
        }

        private void button_export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new();
            saveFileDialog.FileName = DateTime.Now.ToString("yyyy-MM-dd_HHmmss") + ".log";
            saveFileDialog.DefaultExt = "日志文件|*.log";
            var result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, Runtime.logs.ToString());
            }
        }
    }
}
