using System;

namespace Spiral
{
    public static class MessageDisplayer
    {
        const int ROW = 1;
        const int COL = 50;

        public static void Alert (string msg)
        {
            Erase();
            Console.SetCursorPosition(COL, ROW);
            Console.Write(msg);
        }

        private static void Erase ()
        {
            Console.SetCursorPosition(COL, ROW);
            Console.Write(new string(' ', 50));
        }
    }
}
