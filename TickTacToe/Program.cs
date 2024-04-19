using TickTacToe;

ITicTacToe game = new ConsoleTicTacToe(new ConsolePalyer(Symbol.O), new ConsolePalyer(Symbol.X), new Board(3));

Result result = game.Start();

if (result.IsDraw) Console.WriteLine("Game end's at draw");
else
{
    Console.WriteLine($"Winner is {result.Winner.Symbol} ");
}