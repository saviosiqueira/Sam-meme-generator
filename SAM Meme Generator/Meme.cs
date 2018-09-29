using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAM_Meme_Generator
{
    public class Meme
    {
        public string Texto1 { get; set; }

        public string Texto2 { get; set; }

        public string Texto3 { get; set; }

        public Image MemeImage { get; set; }

        public String MemeCompleto()
        {
            return Texto1 + " " + Texto2 + " " + Texto3;
        }
    }
}
