using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaskMarko01
{
    class tervitus
    {
        public string nimi;
        public string vastus;

        public string tere() {

            if (nimi != "")
            {
                vastus = "Tere, " + nimi + "!";
            }
            else {
                vastus = "Palun, Teie nimi!!!";
            }
            return vastus;
        }
    }
}
