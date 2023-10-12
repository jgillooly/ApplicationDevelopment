using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCoolestTicTacToe
{
    internal class Game
    {
        enum GState
        {
            Start,
            Playing,
            GameOver
        }
        private GState state = GState.Start;
        private bool running = true;
        private bool over;
        int currentPlayer;
        Player player1;
        Player player2;
        private Board board;
        public void Run()
        {
            while (running)
            {
                switch (state)
                {
                    case GState.Start:
                        board = new Board();
                        board.ClearBoard();
                        string name = getValidString("Enter Player 1 name:");
                        char mark = chooseMark();
                        player1 = new Player(name, mark);
                        name = getValidString("Enter Player 2 name:");
                        player2 = new Player(name, (mark == 'X' ? 'O' : 'X'));

                        currentPlayer = (player1.mark == 'X' ? 1 : 2);

                        state = GState.Playing;
                        break;
                    case GState.Playing:
                        board.Display();
                        string currentName = (currentPlayer == 1 ? player1.name : player2.name);
                        Console.WriteLine(currentName + " it is your turn.");
                        tryToPlace();
                        over = board.checkForWin();
                        if (over)
                        {
                            state = GState.GameOver;
                        }
                        currentPlayer = (currentPlayer == 1 ? 2 : 1);
                        break;
                    case GState.GameOver:
                        board.Display();
                        if (board.winner == '0')
                        {
                            Console.WriteLine("Tie game");
                        }
                        else
                        {
                            string winnerStr = (player1.mark == board.winner ? player1.name : player2.name);
                            Console.WriteLine(winnerStr + " wins!");
                        }
                        running = false;
                        break;
                }
            }
        }

        private void tryToPlace()
        {
            while (true)
            {
                Console.WriteLine("Enter a row");
                int row = getValidInt(1, 3);
                Console.WriteLine("Enter a column");
                int column = getValidInt(1, 3);
                char mark = (currentPlayer == 1 ? player1.mark : player2.mark);
                bool success = board.PlaceMark(mark, row - 1, column - 1);
                if (success) break;
                Console.WriteLine("Invalid Placement. Try again");
                board.Display();
            }
        }

        private bool between(int num, int x, int y)
        {
            return (num >= x) && (num <= y);
        }

        private int getValidInt(int min, int max)
        {
            while (true)
            {
                Console.WriteLine("Enter a number between " + min + " and " + max + ":");
                string? input = Console.ReadLine();
                if (input != null)
                {
                    int output = -1;
                    try
                    {
                        output = int.Parse(input);
                    } catch (Exception) { }
                    if (output != -1)
                    {
                        if (between(output, min, max)) return output;
                        Console.WriteLine("Number outside range");
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid number");
                    }
                }

            }
        }
        private string getValidString(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                string? value = Console.ReadLine();
                if (value != null) return value;
            }
        }

        private char chooseMark()
        {
            while (true)
            {
                string response = getValidString("Choose X or O:");
                if (response.ToLower() == "x" || response.ToLower() == "o") return response.ToUpper().ToCharArray()[0];
                Console.WriteLine("Incorrect selection");
            }
        }
    }
}
