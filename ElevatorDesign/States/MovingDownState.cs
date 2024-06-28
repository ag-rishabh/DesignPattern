using ElevatorDesign.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorDesign.States
{
    public class MovingDownState : ElevatorStates
    {
        private readonly Elevator _elevator;

        public MovingDownState(Elevator elevator)
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
            if (topDirection == Direction.UP)
            {
                _elevator.State = new MovingUpState(_elevator);
            }
        }

        public State GetName()
        {
            return State.MOVIFDOWN;
        }

        public void Open(Floor floor)
        {
            throw new NotImplementedException();
        }

        public void Stop(Floor floor)
        {
            _elevator.MoveStore.ClearTop();
            _elevator.State = new IdleState(_elevator);
        }
    }
}
