using ElevatorDesign.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorDesign.States
{
    public class UpDirectionComparator : IComparer<Move>
    {
        public int Compare(Move? x, Move? y)
        {
            return x.DestinationFloor.Number - y.DestinationFloor.Number;
        }
    }

    public class DownDirectionComparator : IComparer<Move>
    {
        public int Compare(Move? x, Move? y)
        {
            return  y.DestinationFloor.Number - x.DestinationFloor.Number;
        }
    }

    public class UniDirectionMoveStore : MoveStore
    {
        private readonly PriorityQueue<Move, Move> _upMove;
        private readonly PriorityQueue<Move, Move> _downMove;
        private Direction _currentDirection;


        public UniDirectionMoveStore()
        {
            _upMove = new PriorityQueue<Move, Move>(new UpDirectionComparator());
            _downMove = new PriorityQueue<Move, Move>(new DownDirectionComparator());
            _currentDirection = Direction.HALT;
        }


        public void AddMove(Move move)
        {
            if(_upMove.Count  == 0 && _downMove.Count == 0)
            {
                _currentDirection = move.Direction;
            }

            if(move.Direction == Direction.UP)
            {
                _upMove.Enqueue(move, move);
            }
            else
            {
                _downMove.Enqueue(move, move);
            }
        }

        public void ClearTop()
        {
            if (_upMove.Count == 0 && _downMove.Count == 0) throw new Exception();

            if (_currentDirection == Direction.UP)
            {
                _upMove.Dequeue();
                if(_upMove.Count == 0)
                {
                    if(_downMove.Count != 0)
                    {
                        _currentDirection = Direction.DOWN;
                    } 
                    else
                    {
                        _currentDirection = Direction.HALT;
                    }
                }
            } 
            else
            {
                _downMove.Dequeue();
                if (_downMove.Count == 0)
                {
                    if (_upMove.Count != 0)
                    {
                        _currentDirection = Direction.UP;
                    }
                    else
                    {
                        _currentDirection = Direction.HALT;
                    }
                }
            }
        }

        public Direction GetCurrentDirection()
        {
            return _currentDirection;
        }

        public Move? GetTop()
        {
            if(_upMove.Count == 0 && _downMove.Count == 0) return null;

            if(_currentDirection == Direction.UP) return _upMove.Peek();

            return _downMove.Peek();
        }
    }
}
