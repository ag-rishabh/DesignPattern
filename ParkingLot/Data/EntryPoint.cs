using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Data
{
    public class EntryPoint
    {
        public string Name { get; init; }
        public bool IsOpen { get; init; }

        public EntryPoint(string name, bool isOpen)
        {
            Name = name;
            IsOpen = isOpen;
        }
    }
}
