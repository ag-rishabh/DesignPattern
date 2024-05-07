using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class BoardInitializer
    {
        public int NumberOfSnakes { get; init; }

        public int NumberOfLadder { get; init; }

        public int BoardSize { get; init; }

        public Board Board { get; private set; }

        public BoardInitializer(int numberOfSnakes, int numberOfLadder, int boardSize)
        {
            NumberOfSnakes = numberOfSnakes;
            NumberOfLadder = numberOfLadder;
            BoardSize = boardSize;
            Board = new Board(boardSize);
        }

        private void InitBoard()
        {
            HashSet<int> usedPostion = new HashSet<int>();
            GenerateSnake(usedPostion);
            GenerateLadder(usedPostion);
        }

        private void GenerateSnake(HashSet<int> usedPostion)
        {
            for(int i = 0; i< NumberOfSnakes; i++)
            {
                while (true)
                {
                    int start = GenerateRandomPosition(Board.Start, Board.End);
                    int end = GenerateRandomPosition(Board.Start, Board.End);
                    if (end >= start) continue;

                    if (!usedPostion.Contains(start))
                    {
                        Snake snake = new Snake(start, end);
                        Board.AddSnake(snake);
                        usedPostion.Add(start);
                        break;
                    }
                }
            }
        }

        private void GenerateLadder(HashSet<int> usedPostion)
        {
            for(int i = 0;i< NumberOfLadder; i++)
            {
                while (true)
                {
                    int start = GenerateRandomPosition(Board.Start, Board.End);
                    int end = GenerateRandomPosition(Board.Start, Board.End);
                    if (start >= end) continue;

                    if (!usedPostion.Contains(start))
                    {
                        Ladder ladder = new Ladder(start, end);
                        Board.AddLadder(ladder);
                        usedPostion.Add(start);
                        break;
                    }
                }
            }
        }

        private int GenerateRandomPosition(int start, int end)
        {
            return new Random().Next(start, end+1);
        }
    }
}
