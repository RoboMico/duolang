using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuoLang
{
    public class Settings
    {
        public bool ignoreSameValue = true;
        public bool ignoreComments = true;
        public Color untranslatedColor = ColorTranslator.FromHtml("#D5B32B");
    }
}
