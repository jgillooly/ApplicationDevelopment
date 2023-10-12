using System.Reflection;
using TheCoolestTicTacToe;
bool running = true;
while (running)
{
    Game game = new Game();
    game.Run();
    running = askUser("Play again? (yes/no)", "yes", "no");
}

bool askUser(string prompt, string yestxt, string notxt)
{
    while (true)
    {
        Console.WriteLine(prompt);
        string? response = Console.ReadLine();
        if (response.ToLower() == yestxt.ToLower() || response.ToLower() == notxt.ToLower())
        {
            return (response.ToLower() == yestxt.ToLower()) ? true : false;
        }
        Console.WriteLine("Invalid response");
    }
}