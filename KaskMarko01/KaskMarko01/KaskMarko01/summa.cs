using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaskMarko01
{
    class summa
    {
        public float number1;
        public float number2;
        public string tehing = "";
        public float rezult;

        public float arvutus() {
            if (tehing == "+")
            {
                rezult = number1 + number2;
            }
            else if (tehing == "-") {
                rezult = number1 - number2;
            }
            return rezult;
        }
    }
}
