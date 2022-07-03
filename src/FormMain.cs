using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DuoLang
{
    public partial class FormMain : Form
    {
        private string originalLanguageFile;
        private string targetLanguageFile;
        public FormMain()
        {
            //Load Setting from file
            try
            {
                Runtime.settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText("settings.json"));
            }
            catch
            {
                Runtime.settings = new();
                File.WriteAllText("settings.json", JsonConvert.SerializeObject(Runtime.settings));
            }
            //Set style

            InitializeComponent();
            foreach (Control control in this.Controls)
            {
                control.BackColor = ColorTranslator.FromHtml( Runtime.settings.colorSet.background);
                control.ForeColor = ColorTranslator.FromHtml(Runtime.settings.colorSet.text);
            }
            dataGridView_main.BackgroundColor = ColorTranslator.FromHtml(Runtime.settings.colorSet.background);
            DataGridViewCellStyle style = new()
            {
                BackColor = ColorTranslator.FromHtml(Runtime.settings.colorSet.cell),
                ForeColor = ColorTranslator.FromHtml(Runtime.settings.colorSet.text),
                SelectionBackColor = ColorTranslator.FromHtml(Runtime.settings.colorSet.selectedCell),
                SelectionForeColor = ColorTranslator.FromHtml(Runtime.settings.colorSet.selectedText)
            };
            dataGridView_main.RowHeadersDefaultCellStyle = style;
            dataGridView_main.ColumnHeadersDefaultCellStyle = style;
            dataGridView_main.DefaultCellStyle = style;
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
            dataGridView_main.Rows.Clear();
            for (int i = 0; i < keyList.Count; i++)
            {
                string key = keyList[i];
                if (!Runtime.settings.ignoreComments || !key.StartsWith("__"))
                {
                    bool exist = targetLanguage.TryGetValue(key, out string target);
                    if (Runtime.settings.ignoreSameValue
                        ? (!exist || originalLanguage[key] == target)
                        : !exist)
                    {
                        target = "";
                    }
                    dataGridView_main.Rows.Add(key, originalLanguage[key], target);
                }
                else
                {
                    WriteLog("已忽略翻译键：" + key);
                }
            }
            for (int i = 0; i < dataGridView_main.RowCount; i++)
            {
                UpdateColor(i);
            }
            statusStripStatusLabel_totalKeys.Text = "翻译键数量: " + dataGridView_main.RowCount;
            UpdateCounter();
        }
        private void UpdateColor(int rowIndex)
        {
            bool targetEmpty = string.IsNullOrWhiteSpace((string)dataGridView_main.Rows[rowIndex].Cells["ColumnTargetLanguage"].Value);
            dataGridView_main.Rows[rowIndex].Cells["ColumnKey"].Style.ForeColor = Color.Black; //默认颜色
            if (targetEmpty) //未翻译
            {
                dataGridView_main.Rows[rowIndex].Cells["ColumnKey"].Style.ForeColor = ColorTranslator.FromHtml(Runtime.settings.colorSet.untranslated);
            }
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e) //快捷键
        {
            if (e.KeyCode == Keys.S && e.Modifiers == (Keys.Control | Keys.Shift)) //Ctrl+Shift+S
            {
                toolStripMenuItem_saveAs_Click(this, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control) //Ctrl+S
            {
                toolStripMenuItem_save_Click(this, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.R && e.Modifiers == Keys.Control) //Ctrl+R
            {
                toolStripMenuItem_reload_Click(this, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.L && e.Modifiers == Keys.Control) //Ctrl+L
            {
                toolStripMenuItem_openLogs_Click(this, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.I && e.Modifiers == Keys.Control) //Ctrl+I
            {
                toolStripMenuItem_loadSourceLanguage_Click(this, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.O && e.Modifiers == Keys.Control) //Ctrl+O
            {
                toolStripMenuItem_loadTargetLanguage_Click(this, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.OemPeriod && e.Modifiers == Keys.Control) //Ctrl+,
            {
                toolStripMenuItem_settings_Click(this, EventArgs.Empty);
            }
        }
        private void UpdateCounter()
        {
            int count = 0;
            for (int i = 0; i < dataGridView_main.RowCount; i++)
            {
                if (string.IsNullOrEmpty((string)dataGridView_main.Rows[i].Cells["ColumnTargetLanguage"].Value))
                {
                    count++;
                }
            }
            statusStripStatusLabel_translated.Text = "已翻译: " + (dataGridView_main.RowCount - count);
            statusStripProgressBar_progress.Value = (dataGridView_main.RowCount - count) * 100 / dataGridView_main.RowCount;
            statusStripStatusLabel_progress.Text = $"翻译进度：{Math.Round((double)(dataGridView_main.RowCount - count) / dataGridView_main.RowCount * 1000) / 10}%";
        }

        private void WriteLog(string content)
        {
            Runtime.logs.Append(string.Format("[{0}] {1}\n", DateTime.Now.ToString("HH:mm:ss"), content));
        }

        private void FormMain_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView_main.RowCount; i++)
            {
                UpdateColor(i);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!statusStripStatusLabel_saved.Visible && !string.IsNullOrEmpty(targetLanguageFile))
            {
                if (MessageBox.Show("你还有更改未保存，确定退出吗？", "未保存更改", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void dataGridView_main_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                string defaultString = (string)dataGridView_main.Rows[e.RowIndex].Cells[2].Value;
                FormEditing formEditing = new(defaultString);
                formEditing.ShowDialog();
                dataGridView_main.Rows[e.RowIndex].Cells[2].Value = formEditing.lastEditedText;
                UpdateColor(e.RowIndex);
                UpdateCounter();
            }
        }

        private void toolStripMenuItem_loadSourceLanguage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new();
            openFile.Filter = "JSON文件|*.json";
            openFile.Multiselect = false;
            var result = openFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                originalLanguageFile = openFile.FileName;
                UpdateDGV();
                WriteLog("已加载源语言文件：" + originalLanguageFile);
            }
        }

        private void toolStripMenuItem_loadTargetLanguage_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(targetLanguageFile))
            {
                if (MessageBox.Show("这会丢失所有未保存的更改，确定继续吗？", "加载语言文件", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
            }
            OpenFileDialog openFile = new();
            openFile.Filter = "JSON文件|*.json";
            openFile.Multiselect = false;
            var result = openFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                targetLanguageFile = openFile.FileName;
                UpdateDGV();
                WriteLog("已加载目标语言文件：" + targetLanguageFile);
            }

        }

        private void toolStripMenuItem_reload_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(targetLanguageFile))
            {
                if (MessageBox.Show("这会丢失所有未保存的更改，确定继续吗？", "重新加载", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
            }
            UpdateDGV();
            WriteLog("重新加载...");

        }

        private void toolStripMenuItem_save_Click(object sender, EventArgs e)
        {
            try
            {
                File.OpenWrite(targetLanguageFile).Close();
            }
            catch
            {
                toolStripMenuItem_saveAs_Click(this, EventArgs.Empty);
                return;
            }
            Dictionary<string, string> export = new();
            for (int i = 0; i < dataGridView_main.Rows.Count; i++)
            {
                string key = (string)dataGridView_main.Rows[i].Cells["ColumnKey"].Value;
                string value = (string)dataGridView_main.Rows[i].Cells["ColumnTargetLanguage"].Value;
                if (!string.IsNullOrEmpty(value))
                {
                    export.Add(key, value);
                }
            }
            export.Add("__comment_vt", "Generated by DuoLang DuoLang: https://gitlab.com/MineCommander/vtd");
            File.WriteAllText(targetLanguageFile, JsonConvert.SerializeObject(export, Formatting.Indented));
            statusStripStatusLabel_saved.Visible = true;
            WriteLog("已保存");
        }

        private void toolStripMenuItem_saveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new();
            saveFileDialog.Filter = "JSON文件|*.json";
            saveFileDialog.DefaultExt = "json";
            var result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrEmpty(saveFileDialog.FileName))
            {
                targetLanguageFile = saveFileDialog.FileName;
                toolStripMenuItem_save_Click(this, EventArgs.Empty);
                WriteLog("更改目标语言文件保存位置：" + originalLanguageFile);
            }
        }

        private void toolStripMenuItem_settings_Click(object sender, EventArgs e)
        {
            new FormSettings().ShowDialog();
        }

        private void toolStripMenuItem_openLogs_Click(object sender, EventArgs e)
        {
            new FormLogs().ShowDialog();
        }
    }
}
