using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA230216
{
    internal class MoHegyei
    {
        public string HegycsucsNeve;
        public string Hegyseg;
        public int Magassag;

        public MoHegyei(string nev, string hegyseg, string magassag)
        {
            HegycsucsNeve = nev;
            Hegyseg = hegyseg;
            Magassag = int.Parse(magassag);
        }
    }
}
