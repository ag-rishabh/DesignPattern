using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Player
    {
        public int Id { get; private set; }

        public int Position { get; set; }

        public bool Won { get; set; }   

        public Player(int id) 
        {
            Id = id;
            Won = false;
        }
    }
}
