using ElevatorDesign.Data;

namespace ElevatorDesign.States
{
    public interface ElevatorStates
    {
        void Destine(Floor floor, Direction direction);

        void Open(Floor floor);

        void Close(Floor floor);

        void Stop(Floor floor);

        State GetName();
    }
}
