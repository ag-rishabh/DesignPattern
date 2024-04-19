using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickTacToe
{
    public class ConsolePalyer : IPlayer
    {
        public Symbol Symbol { get; }

        public ConsolePalyer(Symbol symbol)
        {
            Symbol = symbol;
        }

        public Move Play()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Move move = new Move(x, y);
            return move;
        }
    }
}
