using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Board
    {
        public int Start { get; init; }

        public int End { get; init; }

        public List<Snake> Snakes { get; private set; }

        public List<Ladder> Ladder { get; private set; }

        public Board(int size)
        {
            Start = 1;
            End = size;
            Snakes = new List<Snake>();
            Ladder = new List<Ladder>();
        }

        public void AddSnake(Snake snake)
        {
            Snakes.Add(snake);
        }

        public void AddLadder(Ladder ladder)
        {
            Ladder.Add(ladder);
        }
    }
}
