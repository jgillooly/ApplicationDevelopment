using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCoolestTicTacToe
{
    internal class Board
    {
        public Board()
        {
            spaces = new char[3, 3];
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
                    Console.Write(spaces[i, j]);
                    if (j < 2) { Console.Write('|'); }
                }
                Console.WriteLine();
            }
        }

        public bool checkForWin()
        {
            if (spaces[0, 0] == spaces[0, 1] && spaces[0, 0] == spaces[0, 2] && spaces[0, 0] != '_')
            {
                over = true;
                winner = spaces[0, 0];
            }
            else if (spaces[1, 0] == spaces[1, 1] && spaces[1, 0] == spaces[1, 2] && spaces[1, 0] != '_')
            {
                over = true;
                winner = spaces[1, 0];
            }
            else if (spaces[2, 0] == spaces[2, 1] && spaces[2, 0] == spaces[2, 2] && spaces[2, 0] != '_')
            {
                over = true;
                winner = spaces[2, 0];
            }
            else if (spaces[0, 0] == spaces[1, 0] && spaces[0, 0] == spaces[2, 0] && spaces[0, 0] != '_')
            {
                over = true;
                winner = spaces[0, 0];
            }
            else if (spaces[0, 1] == spaces[1, 1] && spaces[0, 1] == spaces[2, 1] && spaces[0, 1] != '_')
            {
                over = true;
                winner = spaces[0, 1];
            }
            else if (spaces[0, 2] == spaces[1, 2] && spaces[0, 2] == spaces[2, 2] && spaces[0, 2] != '_')
            {
                over = true;
                winner = spaces[0, 2];
            }
            else if (spaces[0, 0] == spaces[1, 1] && spaces[0, 0] == spaces[2, 2] && spaces[0, 0] != '_')
            {
                over = true;
                winner = spaces[0, 0];
            }
            else if (spaces[0, 2] == spaces[1, 1] && spaces[0, 2] == spaces[2, 0] && spaces[0, 2] != '_')
            {
                over = true;
                winner = spaces[0, 2];
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
                for (int j = 0; j < 3; j++)
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
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    spaces[i, j] = '_';
                }
            }
        }
    }
}
