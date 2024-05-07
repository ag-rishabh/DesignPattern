using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Dice
    {
        public int DiceCount { get; private set; }

        public int MaxValue { get; private set; }

        public int MinValue { get; private set; }

        public Dice(int diceCount, int maxValue, int minValue)
        {
            DiceCount = diceCount;
            MaxValue = maxValue;
            MinValue = minValue;
        }

        public int Roll()
        {
            int totalSum = 0;
            for(int i = 0; i < DiceCount; i++)
            {
                totalSum += new Random().Next(MinValue, MaxValue+1);
            }
            return totalSum;
        }

    }
}
