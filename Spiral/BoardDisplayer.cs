using System;
using System.Text.RegularExpressions;

namespace Spiral
{
    public static class BoardDisplayer
    {
        public static string AddSpaces (string board)
        {
            return Regex.Replace(board, ".{1}", "$0 ");
        }

        public static void Output (Board board)
        {
            string boardStr = AddSpaces(board.ToString());
            Console.SetCursorPosition(0, 0);
            foreach (char cell in boardStr)
            {
                SetColor(cell);
                Console.Write(cell);
            }
            board.Player.Write();
        }

        public static void OutputCell (char cell, int col, int row)
        {
            Console.SetCursorPosition(col, row);
            SetColor(cell);
            Console.Write(cell);
        }

        private static void SetColor (char cell)
        {
            switch (cell)
            {
                default:
                    Console.ResetColor();
                    break;

                case '#':
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case '.':
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;

                case 'X':
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;

                case '$':
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;

                case '*':
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
            }
        }
    }
}
