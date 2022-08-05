using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kask02
{
    class Calculation
    {
        public float number1;
        public float number2;
        public string transaction = "";
        public float score;

        public float calculate(string transaction) {

            switch (transaction) {
                case "+": score = number1 + number2;
                    break;
                case "-": score = number1 - number2;
                    break;
                case "*": score = number1 * number2;
                    break;
                case "/": score = number1 / number2;
                    break;
                default:
                    score = 0;
                    break;
            }
            return score;
        }
    }
}
