using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Ladder : BoardEntities
    {
        public Ladder(int start, int end) : base(start, end)
        {
        }

        public override string GetEncounterMessage()
        {
            return "Yeyyy!, You have a stair to climb :)";
        }
    }
}
