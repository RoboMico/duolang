using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuoLang
{
    public class Runtime
    {
        public static Settings settings = new();
        public static StringBuilder logs = new();
        public static Version VERSION { get { return new Version("0.1.0"); } }
    }
}
