using ElevatorDesign.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorDesign.Data
{
    public class Elevator
    {
        public Floor CurrentFloor { get; set; }

        public ElevatorStates State { get; set; }

        public MoveStore MoveStore { get; init; }

        public Elevator(MoveStore moveStore)
        {
            MoveStore = moveStore;
        }

        public void Destine(Floor floor, Direction direction)
        {
            State.Destine(floor, direction);
        }

        public void Open(Floor floor)
        {
            State.Open(floor);
        }

        public void Close(Floor floor)
        {
            State.Close(floor);
        }

        public void Stop(Floor floor)
        {
            State.Stop(floor);
        }
    }
}
