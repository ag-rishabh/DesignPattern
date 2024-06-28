using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorDesign.Data
{
    public class Floor
    {
        public Floor(int number, string name)
        {
            Number = number;
            Name = name;
        }

        public int Number { get; init; }
        public string Name { get; init; }


    }
}
