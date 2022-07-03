using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuoLang
{
    public class ColorTextBox : TextBox
    {
        protected override void OnDoubleClick(EventArgs e)
        {
            ColorDialog colorDialog = new();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Text = ColorTranslator.ToHtml(colorDialog.Color);
            }
            base.OnDoubleClick(e);
        }
    }
}
