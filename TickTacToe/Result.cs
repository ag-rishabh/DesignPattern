using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickTacToe
{
    public class Result
    {
        public readonly bool IsDraw;

        public readonly IPlayer Winner;

        public Result(bool isDraw, IPlayer winner)
        {
            IsDraw = isDraw;
            Winner = winner;
        }
    }
}
