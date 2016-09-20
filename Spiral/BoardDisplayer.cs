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
                switch (cell)
                {
                    default:
                        Console.ResetColor();
                        break;

                    case '#':
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;

                    case '.':
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                }
                Console.Write(cell);
            }
            board.Player.Write();
        }
    }
}
