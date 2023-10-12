using System.Reflection;

Board board = new Board();
board.ClearBoard();
string name = getValidString("Enter Player 1 name:");
char mark = chooseMark();
Player player1 = new Player(name, mark);
name = getValidString("Enter Player 2 name:");
Player player2 = new Player(name, (mark == 'X' ? 'O' : 'X'));

int currentPlayer = (player1.mark == 'X' ? 1 : 2);

bool over = false;
while (!over)
{
    board.Display();
    string currentName = (currentPlayer == 1 ? player1.name : player2.name);
    Console.WriteLine(currentName + " it is your turn.");
    while (true)
    {
        Console.WriteLine("Enter a row");
        int row = getValidInt(1, 3);
        Console.WriteLine("Enter a column");
        int column = getValidInt(1, 3);
        mark = (currentPlayer == 1 ? player1.mark : player2.mark);
        bool success = board.PlaceMark(mark, row - 1, column - 1);
        if (success) break;
        Console.WriteLine("Invalid Placement. Try again");
        board.Display();
    }
    over = board.checkForWin();
    if (over)
    {
        break;
    }
    currentPlayer = (currentPlayer == 1 ? 2 : 1);
}
board.Display();
if (board.winner == '0')
{
    Console.WriteLine("Tie game");
} else
{
    string winnerStr = (player1.mark == board.winner ? player1.name : player2.name);
    Console.WriteLine(winnerStr + " wins!");
}

bool between(int num, int x, int y)
{
    return (num >= x) && (num <= y);
}

int getValidInt(int min, int max)
{
    while (true)
    {
        Console.WriteLine("Enter a number between " + min + " and " + max + ":");
        string? input = Console.ReadLine();
        if (input != null)
        {
            int output = -1;
            output = int.Parse(input);
            if (output != -1)
            {
                if (between(output, min, max)) return output;
                Console.WriteLine("Number outside range");
            } else
            {
                Console.WriteLine("Enter a valid number");
            }
        }

    }
}
string getValidString(string prompt)
{
    while (true)
    {
        Console.WriteLine(prompt);
        string? value = Console.ReadLine();
        if (value != null) return value;
    }
}

char chooseMark()
{
    while (true)
    {
        string response = getValidString("Choose X or O:");
        if (response.ToLower() == "x" || response.ToLower() == "o") return response.ToUpper().ToCharArray()[0];
        Console.WriteLine("Incorrect selection");
    }
}

public class Player
{
    public Player(string iname, char imark) { name = iname; mark = imark; }
    public string name { get; set; }
    public char mark { get; set; }
}


public class Board
{   
    public Board()
    {
        spaces = new char[3,3];
    }

    private char[,] spaces;
    private bool over;
    public char winner = '0';
    public void Display()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(spaces[i,j]);
                if (j < 2) { Console.Write('|'); }
            }
            Console.WriteLine();
        }
    }

    public bool checkForWin()
    {
        if (spaces[0,0] == spaces[0,1] && spaces[0,0] == spaces[0,2] && spaces[0,0] != '_')
        {
            over = true;
            winner = spaces[0,0];
        }
        else if (spaces[1,0] == spaces[1,1] && spaces[1,0] == spaces[1,2] && spaces[1,0] != '_')
        {
            over = true;
            winner = spaces[1,0];
        }
        else if (spaces[2,0] == spaces[2,1] && spaces[2,0] == spaces[2,2] && spaces[2,0] != '_')
        {
            over = true;
            winner = spaces[2,0];
        }
        else if (spaces[0,0] == spaces[1,0] && spaces[0,0] == spaces[2,0] && spaces[0,0] != '_')
        {
            over = true;
            winner = spaces[0,0];
        }
        else if (spaces[0,1] == spaces[1,1] && spaces[0,1] == spaces[2,1] && spaces[0,1] != '_')
        {
            over = true;
            winner = spaces[0,1];
        }
        else if (spaces[0,2] == spaces[1,2] && spaces[0,2] == spaces[2,2] && spaces[0,2] != '_')
        {
            over = true;
            winner = spaces[0,2];
        }
        else if (spaces[0,0] == spaces[1,1] && spaces[0,0] == spaces[2,2] && spaces[0,0] != '_')
        {
            over = true;
            winner = spaces[0,0];
        }
        else if (spaces[0,2] == spaces[1,1] && spaces[0,2] == spaces[2,0] && spaces[0,2] != '_')
        {
            over = true;
            winner = spaces[0,2];
        }
        else if (isBoardFull() && winner == '0')
        {
            over = true;
        }
        return over;
    }

    private bool isBoardFull()
    {
        for (int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                if (spaces[i, j] == '_') return false;
            }
        }
        return true;
    }

    private bool between(int num, int x, int y)
    {
        return (num >= x) && (num <= y);
    }

    public bool isValidPlacement(int row, int column) //location parameter
    {
        //check if invalid
        return between(row, 0, 3) && between(column, 0, 3) && spaces[row, column] == '_';
    }

    public bool PlaceMark(char mark, int row, int column) //parameters including mark and player
    {
        //check for validation
        if (!isValidPlacement(row, column)) { return false; }
        //update board spaces attribute

        spaces[row, column] = mark;
        return true;
    }

    public void ClearBoard()
    {
        for (int i  = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                spaces[i,j] = '_';
            }
        }
    }
}