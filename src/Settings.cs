using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualTranslate
{
    public class Settings
    {
        public static StringBuilder logs = new();
        public enum LockedValueSaveSettings
        {
            Never = 0,
            NotEmpty = 1,
            Always = 2
        }
        public static bool ignoreSameValue = true;
        public static LockedValueSaveSettings saveLockedValues = LockedValueSaveSettings.NotEmpty;
        public static Color untranslatedColor = ColorTranslator.FromHtml("#D5B32B");
    }
}
