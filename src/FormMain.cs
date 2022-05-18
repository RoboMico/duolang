using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace VisualTranslate
{
    public partial class FormMain : Form
    {
        private string originalLanguageFile;
        private string targetLanguageFile;
        public FormMain()
        {
            InitializeComponent();
        }

        private void button_loadOriginalLanguage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new();
            openFile.Filter = "JSON文件|*.json";
            openFile.Multiselect = false;
            openFile.ShowDialog();
            originalLanguageFile = openFile.FileName;
            label_originalLanguage.Text = Path.GetFileName(openFile.FileName);
            UpdateDGV();
            WriteLog("已加载源语言文件：" + originalLanguageFile);
        }
        private void button_loadTargetLanguage_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(targetLanguageFile))
            {
                if (MessageBox.Show("这会丢失所有未保存的更改，确定继续吗？", "加载语言文件", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            OpenFileDialog openFile = new();
            openFile.Filter = "JSON文件|*.json";
            openFile.Multiselect = false;
            openFile.ShowDialog();
            targetLanguageFile = openFile.FileName;
            label_targetLanguage.Text = Path.GetFileName(openFile.FileName);
            UpdateDGV();
            WriteLog("已加载目标语言文件：" + targetLanguageFile);
        }

        private void UpdateDGV()
        {
            Dictionary<string, string> originalLanguage = new();
            Dictionary<string, string> targetLanguage = new();
            if (File.Exists(originalLanguageFile))
            {
                originalLanguage = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(originalLanguageFile));
            }
            if (File.Exists(targetLanguageFile))
            {
                targetLanguage = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(targetLanguageFile));
            }
            List<string> keyList = new();
            foreach (var key in originalLanguage.Keys)
            {
                keyList.Add(key);
            }
            dataGridView1.Rows.Clear();
            for (int i = 0; i < keyList.Count; i++)
            {
                string key = keyList[i];
                if (!key.StartsWith("__"))
                {
                    dataGridView1.Rows.Add(key,
                        originalLanguage[key],
                        (targetLanguage.ContainsKey(key) && targetLanguage[key] != originalLanguage[key]) ? targetLanguage[key] : "");
                }
                else
                {
                    WriteLog("已忽略翻译键：" + key);
                }
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                UpdateColor(i);
            }
            label_keyCount.Text = "翻译键数量: " + dataGridView1.RowCount;
            UpdateCounter();
        }

        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            button_log.Location = new Point(Size.Width - 128, button_log.Location.Y);
            button_settings.Location = new Point(Size.Width - 128, button_settings.Location.Y);
            button_saveAs.Location = new Point(Size.Width - 234, button_saveAs.Location.Y);
            button_save.Location = new Point(Size.Width - 234, button_save.Location.Y);
        }

        private void button_settings_Click(object sender, EventArgs e)
        {
            new FormSettings().ShowDialog();
        }
        private void UpdateColor(int rowIndex)
        {
            bool targetEmpty = string.IsNullOrWhiteSpace((string)dataGridView1.Rows[rowIndex].Cells["ColumnTargetLanguage"].Value);
            dataGridView1.Rows[rowIndex].Cells["ColumnKey"].Style.ForeColor = Color.Black; //默认颜色
            if (targetEmpty) //未翻译
            {
                dataGridView1.Rows[rowIndex].Cells["ColumnKey"].Style.ForeColor = Settings.untranslatedColor;
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            //DataGridViewRow dr = dataGridView1.Rows[rowIndex];
            //dataGridView1.Rows.RemoveAt(rowIndex);
            //dataGridView1.Rows.Insert(rowIndex, dr);
            label_saved.Hide();
            UpdateCounter();
            UpdateColor(rowIndex);
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> export = new();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string key = (string)dataGridView1.Rows[i].Cells["ColumnKey"].Value;
                string value = (string)dataGridView1.Rows[i].Cells["ColumnTargetLanguage"].Value;
                if (!string.IsNullOrEmpty(value))
                {
                    export.Add(key, value);
                }
            }
            export.Add("__comment_vt", "Generated by VisualTranslate DuoLang: https://gitlab.com/MineCommander/vtd");
            File.WriteAllText(targetLanguageFile, JsonConvert.SerializeObject(export, Formatting.Indented));
            label_saved.Show();
            WriteLog("已保存");
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)     //Ctrl+S
            {
                button_save_Click(this, EventArgs.Empty);
            }
        }
        private void UpdateCounter()
        {
            int count = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (string.IsNullOrEmpty((string)dataGridView1.Rows[i].Cells["ColumnTargetLanguage"].Value))
                {
                    count++;
                }
            }
            label_untranslatedCount.Text = "未翻译数量: " + count;
        }

        private void button_log_Click(object sender, EventArgs e)
        {
            new FormLogs().ShowDialog();
        }

        private void button_saveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new();
            saveFileDialog.Filter = "JSON文件|*.json";
            saveFileDialog.DefaultExt = "json";
            saveFileDialog.ShowDialog();
            if (!string.IsNullOrEmpty(saveFileDialog.FileName))
            {
                targetLanguageFile = saveFileDialog.FileName;
                button_save_Click(this, EventArgs.Empty);
            }
            WriteLog("更改目标语言文件保存位置：" + originalLanguageFile);
        }

        private void button_reload_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(targetLanguageFile))
            {
                if (MessageBox.Show("这会丢失所有未保存的更改，确定继续吗？", "重新加载", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            UpdateDGV();
            WriteLog("重新加载...");
        }
        private void WriteLog(string content)
        {
            Settings.logs.Append(string.Format("[{0}] {1}\n", DateTime.Now.ToString("HH:mm:ss"), content));
        }

        private void FormMain_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                UpdateColor(i);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!label_saved.Visible && !string.IsNullOrEmpty(targetLanguageFile))
            {
                if (MessageBox.Show("你还有更改未保存，确定退出吗？", "未保存更改", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                string defaultString = (string)dataGridView1.Rows[e.RowIndex].Cells[2].Value;
                FormEditing formEditing = new FormEditing(defaultString);
                formEditing.ShowDialog();
                dataGridView1.Rows[e.RowIndex].Cells[2].Value = formEditing.lastEditedText;
                UpdateColor(e.RowIndex);
                UpdateCounter();
            }
        }
    }
}
