using SnakeAndLadder;

Console.WriteLine("Enter number of snakes");
int snakesCount;
int.TryParse(Console.ReadLine(), out snakesCount);
Console.WriteLine("Enter number of ladder");
int ladderCount;
int.TryParse(Console.ReadLine(), out ladderCount);
Console.WriteLine("Enter board size");
int boardSize;
int.TryParse(Console.ReadLine(), out boardSize);
Console.WriteLine("Enter Number of Player");
int playerCount;
int.TryParse(Console.ReadLine(), out playerCount);

Console.WriteLine($"Snake Count: {snakesCount}");
Console.WriteLine($"Ladder Count: {ladderCount}");
Console.WriteLine($"Board Size: {boardSize}");
Console.WriteLine($"Player Count: {playerCount}");

BoardInitializer boardInitializer = new BoardInitializer(snakesCount, ladderCount, boardSize);

Game game = new Game(boardInitializer.Board, new Dice(1, 6, 1));

    for(int i = 0; i < playerCount; i++)
    {
        Console.WriteLine("Enter Player Id");
        int id;
        int.TryParse(Console.ReadLine(), out id);
        Player player = new Player(id);
        game.AddPlayer(player);
    }
    game.PlayGame();