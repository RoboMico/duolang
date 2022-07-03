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
        public ColorSet colorSet = new();
        public int backgroundAlpha = 100;
        public bool loadPictures = false;
    }
}
