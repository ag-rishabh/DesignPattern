using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Snake : BoardEntities
    {
        public Snake(int start, int end) : base(start, end)
        {
        }

        public override string GetEncounterMessage()
        {
            return "OPPS!, You encountered a Snake";
        }
    }
}
