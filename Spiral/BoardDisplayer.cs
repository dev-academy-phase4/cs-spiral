using System;

namespace Spiral
{
    public static class BoardDisplayer
    {
        public static void Output (string board)
        {
            foreach (char cell in board)
            {
                switch (cell)
                {
                    default:
                        Console.ResetColor();
                        break;

                    case '@':
                        Console.ForegroundColor = ConsoleColor.Red;
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
        }
    }
}
