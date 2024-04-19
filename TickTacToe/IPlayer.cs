using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickTacToe
{
    public interface IPlayer
    {
        Symbol Symbol { get; }

        Move Play();
    }
}
