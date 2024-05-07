using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Game
    {
        public Queue<Player> Players { get; init; }

        public Board Board { get; init; }

        public Dice Dice { get; init; }

        public Game(Board board, Dice dice)
        {
            Players = new Queue<Player>();
            Board = board;
            Dice = dice;
        }

        public void AddPlayer(Player player)
        {
            Players.Enqueue(player);
        }

        public void PlayGame()
        {
            while(Players.Count >= 2)
            {
                Player player = Players.Dequeue();
                int diceVal = Dice.Roll();
                int newPostion = player.Position + diceVal;
                if(newPostion > Board.End)
                {
                    Players.Enqueue(player);
                } 
                else
                {
                    player.Position = GetNewPostion(newPostion);
                    if(HasPlayerWon(newPostion))
                    {
                        player.Won = true;
                        Console.WriteLine($"Player with id: {player.Id} won.");
                    }
                    else
                    {
                        Console.WriteLine($"Setting new postion for player with id: {player.Id} to {player.Position}");
                        Players.Enqueue(player);
                    }
                }
            }
        }

        private int GetNewPostion(int position)
        {
            foreach(Snake snake in Board.Snakes)
            {
                if(snake.Start == position)
                {
                    Console.WriteLine(snake.GetEncounterMessage());
                    return snake.End;
                }
            }

            foreach(Ladder ladder in Board.Ladder)
            {
                if(ladder.Start == position)
                {
                    Console.WriteLine(ladder.GetEncounterMessage());
                    return ladder.End;
                }
            }
            return position;
        }

        private bool HasPlayerWon(int postion)
        {
            return Board.End == postion;
        }
    }
}
