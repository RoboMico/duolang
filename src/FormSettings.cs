using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuoLang
{
    public partial class FormSettings : Form
    {
        private int easter = 0;
        public FormSettings()
        {
            InitializeComponent();
            LoadSettings();
            //set style
            foreach (TabPage tab in tabControl1.TabPages)
            {
                tab.BackColor = ColorTranslator.FromHtml(Runtime.settings.colorSet.background);
                foreach (object control in tab.Controls)
                {
                    if (control is Label label)
                    {
                        label.BackColor = ColorTranslator.FromHtml(Runtime.settings.colorSet.background);
                        label.ForeColor = ColorTranslator.FromHtml(Runtime.settings.colorSet.text);
                    }
                    if (control is Button button)
                    {
                        button.ForeColor = ColorTranslator.FromHtml(Runtime.settings.colorSet.text);
                    }
                    if (control is TextBox textBox)
                    {
                        textBox.BackColor = ColorTranslator.FromHtml(Runtime.settings.colorSet.cell);
                        textBox.ForeColor = ColorTranslator.FromHtml(Runtime.settings.colorSet.text);
                    }
                    if (control is CheckBox checkBox)
                    {
                        checkBox.BackColor = ColorTranslator.FromHtml(Runtime.settings.colorSet.background);
                        checkBox.ForeColor = ColorTranslator.FromHtml(Runtime.settings.colorSet.text);

                    }
                }
            }
        }
        private void LoadSettings()
        {
            textBox_colorTargetUntranslated.Text = Runtime.settings.colorSet.untranslated;
            textBox_colorCell.Text = Runtime.settings.colorSet.cell;
            textBox_colorSelectedCell.Text = Runtime.settings.colorSet.selectedCell;
            textBox_colorCellBorder.Text = Runtime.settings.colorSet.cellBorder;
            textBox_colorBackground.Text = Runtime.settings.colorSet.background;
            textBox_colorText.Text = Runtime.settings.colorSet.text;
            textBox_colorSelectedText.Text = Runtime.settings.colorSet.selectedText;
            checkBox_ignoreSameValue.Checked = Runtime.settings.ignoreSameValue;
            checkBox_ignoreComments.Checked = Runtime.settings.ignoreComments;
            label_version.Text = string.Format(label_version.Text, Runtime.VERSION);
        }
        private void SaveSettings()
        {
            Runtime.settings.ignoreSameValue = checkBox_ignoreSameValue.Checked;
            Runtime.settings.ignoreComments = checkBox_ignoreComments.Checked;
            Runtime.settings.colorSet.untranslated = textBox_colorTargetUntranslated.Text;
            Runtime.settings.colorSet.cell = textBox_colorCell.Text;
            Runtime.settings.colorSet.selectedCell = textBox_colorSelectedCell.Text;
            Runtime.settings.colorSet.cellBorder = textBox_colorCellBorder.Text;
            Runtime.settings.colorSet.text = textBox_colorText.Text;
            Runtime.settings.colorSet.selectedText = textBox_colorSelectedText.Text;
            Runtime.settings.colorSet.background = textBox_colorBackground.Text;
            File.WriteAllText("settings.json", JsonConvert.SerializeObject(Runtime.settings));

        }

        private void linkLabel_checkSources_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe",
                easter >= 10 ? "https://afdian.net/@MineCommander" //打钱
                : "https://gitlab.com/MineCommander/duoLang");
        }

        private void FormSettings_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                easter++;
                if (easter == 10)
                {
                    linkLabel_checkSources.Text = "...没准还能给作者打钱？";
                }
            }
        }

        private void FormSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void linkLabel_license_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", "https://anticapitalist.software/");
        }

        private void button_openFolder_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Path.Combine(Environment.ProcessPath, "pictures"));
        }

        private void button_exportColorSet_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new();
            fd.Filter = "JSON文件|*.json";
            fd.DefaultExt = "json";
            try
            {
                var result = fd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    SaveSettings();
                    File.WriteAllText(fd.FileName, JsonConvert.SerializeObject(Runtime.settings.colorSet));
                    MessageBox.Show("导出成功！", "导出配色", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("配色导出失败！\n错误信息：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_importColorSet_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new();
            fd.CheckFileExists = true;
            fd.Filter = "JSON文件|*.json";
            fd.DefaultExt = "json";
            try
            {
                var result = fd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Runtime.settings.colorSet = JsonConvert.DeserializeObject<ColorSet>(File.ReadAllText(fd.FileName));
                    LoadSettings();
                    MessageBox.Show("导入成功！", "导入配色", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("配色导入失败！\n错误信息：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("确定要重置配色方案吗？此操作不可撤销！", "重置为默认", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Runtime.settings.colorSet = new();
                LoadSettings();
            }
        }
    }
}
