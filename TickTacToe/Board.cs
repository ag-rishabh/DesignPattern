using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickTacToe
{
    public class Board
    {
        Symbol[][] board;
        int size;

        public Board(int n)
        {
            size = n;
            board = new Symbol[n][];

            for(int i = 0;i < n; i++)
            {
                board[i] = new Symbol[n];

                for(int j = 0;j < n; j++)
                {
                    board[i][j] = Symbol.Empty;
                }
            }
        }

        public void ApplyMove(Move move, Symbol symbol)
        {
            int x = move.x;
            int y = move.y;

            if (x < 0 || x > size || board[x][y] != Symbol.Empty)
            {
                Console.WriteLine($"Invalid move, Plase enter between 0 ans {size - 1} ");
            }

            if (y < 0 || y > size || board[x][y] != Symbol.Empty)
            {
                Console.WriteLine($"Invalid move, Plase enter between 0 ans {size - 1} ");
            }

            board[x][y] = symbol;

            Console.WriteLine("--------------------------------------------------------------------");
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    if (board[i][j] == Symbol.O) Console.Write("0 ");
                    else if (board[i][j] == Symbol.X) Console.Write("X ");
                    else Console.Write(". ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------------------------------------");
        }

        public bool IsBoardFull()
        {
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    if (board[i][j] == Symbol.Empty) return false;
                }
            }
            return true;
        } 

        public bool IsWinningLine(Symbol symbol)
        {
            return hasHorizontalWinningLine(symbol) || hasVerticalWinningLine(symbol) || hasDiagonalWinningLine(symbol);
        }

        private bool hasDiagonalWinningLine(Symbol symbol)
        {
            int j = 0;
            int count = 0;
            for(int i = 0;i < size;i++)
            {
                if (board[i][j] == symbol)
                {
                    count++;
                    j++;
                } else
                {
                    break;
                }
            }
            if(count== size) return true;

            j = size-1;
            count = 0;
            for(int i = 0;i<size;i++)
            {
                if (board[i][j] == symbol)
                {
                    count++;
                    j--;
                }else
                {
                    break;
                }
            }
            if (count == size) return true;

            return false;
        }

        private bool hasVerticalWinningLine(Symbol symbol)
        {
            for(int i = 0;i < size;i++)
            {
                int count = 0;
                for(int j = 0;j < size;j++)
                {
                    if (board[i][j] == symbol) count++;
                    else break;
                }
                if(count == size) return true;
            }
            return false;
        }

        private bool hasHorizontalWinningLine(Symbol symbol)
        {
            for(int i = 0;i < size;i++)
            {
                int count = 0;

                for(int j = 0;j < size;j++)
                {
                    if (board[i][j] == symbol) count++;
                    else break;
                }
                if(count == size) return true;
            }
            return false;
        }
    }
}
