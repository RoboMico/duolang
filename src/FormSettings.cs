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
            textBox_colorTargetUntranslated.Text = ColorTranslator.ToHtml(Runtime.settings.untranslatedColor);
            checkBox_ignoreSameValue.Checked = Runtime.settings.ignoreSameValue;
            checkBox_ignoreComments.Checked = Runtime.settings.ignoreComments;
            label_version.Text = string.Format(label_version.Text, Runtime.VERSION.ToString());
        }

        private void textBox_colorTargetUntranslated_DoubleClick(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_colorTargetUntranslated.Text = ColorTranslator.ToHtml(colorDialog.Color);
            }
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
            //Save settings
            Runtime.settings.untranslatedColor = ColorTranslator.FromHtml(textBox_colorTargetUntranslated.Text);
            Runtime.settings.ignoreSameValue = checkBox_ignoreSameValue.Checked;
            Runtime.settings.ignoreComments = checkBox_ignoreComments.Checked;
            File.WriteAllText("settings.json", JsonConvert.SerializeObject(Runtime.settings));
        }

        private void linkLabel_license_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", "https://anticapitalist.software/");
        }
    }
}
