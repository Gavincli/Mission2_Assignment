using System;
using System.Collections.Generic;
using System.Text;

namespace Mission2_Assignment
{
    internal class RollDice
    {
        Random rand = new Random();
        public int Roll(int rolls)
        {
            int dice1 = rand.Next(1, 7);
            int dice2 = rand.Next(1, 7);
            int sum = dice1 + dice2;
            return sum; 
        }
    }
}
