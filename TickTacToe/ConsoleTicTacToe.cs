using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickTacToe
{
    public class ConsoleTicTacToe : ITicTacToe
    {
        public IPlayer player1, player2;

        public readonly Board board;

        public ConsoleTicTacToe(IPlayer player1, IPlayer player2, Board board)
        {
            this.player1 = player1;
            this.player2 = player2;
            this.board = board;
        }

       public  Result Start()
        {
           IPlayer currentPlayer = this.player1;
            while(board.IsBoardFull() == false)
            {
                Move move = currentPlayer.Play();
                board.ApplyMove(move, currentPlayer.Symbol);
                if (board.IsWinningLine(currentPlayer.Symbol))
                {
                    return new Result(false, currentPlayer);
                }
                if(currentPlayer == this.player1) currentPlayer = this.player2;
                else currentPlayer = this.player1;
            }

            return new Result(true, null);
        }
    }
}
