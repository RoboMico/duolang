using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualTranslate
{
    public partial class FormSettings : Form
    {
        private int easter = 0;
        public FormSettings()
        {
            InitializeComponent();
        }

        private void textBox_colorEmptyKey_DoubleClick(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_colorEmptyKey.Text = ColorTranslator.ToHtml(colorDialog.Color);
                Settings.emptyKeyColor = colorDialog.Color;
            }
        }

        private void textBox_colorTargetUntranslated_DoubleClick(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_colorTargetUntranslated.Text = ColorTranslator.ToHtml(colorDialog.Color);
                Settings.untranslatedColor = colorDialog.Color;
            }
        }

        private void textBox_colorOriginalNotExist_DoubleClick(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_colorOriginalNotExist.Text = ColorTranslator.ToHtml(colorDialog.Color);
                Settings.originalNotExistColor = colorDialog.Color;
            }
        }

        private void linkLabel_checkSources_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe",
                easter >= 10 ? "https://afdian.net/@MineCommander" //打钱
                : "https://gitlab.com/MineCommander/visual-translate");
        }

        private void FormSettings_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                if (easter < 9)
                {
                    easter++;
                }
                else
                {
                    linkLabel_checkSources.Text = "...没准还能给作者打钱？";
                }
            }
        }
    }
}
