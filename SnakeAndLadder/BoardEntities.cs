using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public abstract class BoardEntities
    {
        public int Start { get; private set; }

        public int End { get; private set; }

        public BoardEntities(int start, int end)
        {
            Start = start;
            End = end;
        }

        public abstract string GetEncounterMessage();
    }
}
