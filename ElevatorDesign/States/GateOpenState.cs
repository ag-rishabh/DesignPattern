using ElevatorDesign.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorDesign.States
{
    public class GateOpenState : ElevatorStates
    {
        private readonly Elevator _elevator;

        public GateOpenState(Elevator elevator)
        {
            _elevator = elevator;
        }

        public void Close(Floor floor)
        {
            Direction direction = _elevator.MoveStore.GetCurrentDirection();
            if(direction == Direction.UP)
            {
                _elevator.State = new MovingUpState(_elevator);
            }
            else if(direction == Direction.DOWN) 
            {
                 _elevator.State = new MovingDownState(_elevator);
            }
            else
            {
                _elevator.State = new IdleState(_elevator);
            }

        }

        public void Destine(Floor floor, Direction direction)
        {
            throw new NotImplementedException();
        }

        public State GetName()
        {
            return State.GATEOPEN;
        }

        public void Open(Floor floor)
        {
            throw new NotImplementedException();
        }

        public void Stop(Floor floor)
        {
            throw new NotImplementedException();
        }
    }
}
