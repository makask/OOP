using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kask03
{
    class Player
    {
        public int dice1;
        public int dice2;

        public Player() {
            dice1 = getRandomDiceNumber();
            dice2 = getRandomDiceNumber();
        }

        public int getRandomDiceNumber() {
            return new Random().Next(1,7);
        }

        public int addDiceNumbers(int firstDice, int secondDice) {
            return firstDice + secondDice;
        }
    }
}
