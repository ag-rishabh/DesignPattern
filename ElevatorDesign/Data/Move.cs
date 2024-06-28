using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorDesign.Data
{
    public class Move
    {
        public Move(Floor destinationFloor, Direction direction)
        {
            DestinationFloor = destinationFloor;
            Direction = direction;
        }

        public Floor DestinationFloor { get; init; }

        public Direction Direction { get; init; }
    }
}
