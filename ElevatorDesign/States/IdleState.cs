using ElevatorDesign.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorDesign.States
{
    public class IdleState : ElevatorStates
    {
        private readonly Elevator _elevator;

        public IdleState(Elevator elevator)
        {
            _elevator = elevator;
        }

        public void Close(Floor floor)
        {
            throw new NotImplementedException();
        }

        public void Destine(Floor floor, Direction direction)
        {
            _elevator.MoveStore.AddMove(new Move(floor, direction));
            Direction topDirection = (Direction)(_elevator.MoveStore.GetTop()?.Direction);
            if (topDirection == Direction.DOWN)
            {
                _elevator.State = new MovingDownState(_elevator);
            }
            else
            {
                _elevator.State = new MovingUpState(_elevator);
            }
        }

        public State GetName()
        {
            throw new NotImplementedException();
        }

        public void Open(Floor floor)
        {
            _elevator.State = new GateOpenState(_elevator);
        }

        public void Stop(Floor floor)
        {
            throw new NotImplementedException();
        }
    }
}
