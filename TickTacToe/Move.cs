using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickTacToe
{
    public class Move
    {
        public int x { get; }

        public int y { get; }   

        public Move(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
