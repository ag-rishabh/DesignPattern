using ElevatorDesign.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorDesign.States
{
    public interface MoveStore
    {
        void AddMove(Move move);

        Move? GetTop();

        void ClearTop();

        Direction GetCurrentDirection();
    }
}
