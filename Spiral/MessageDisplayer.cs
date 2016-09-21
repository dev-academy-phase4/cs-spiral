using System;

namespace Spiral
{
    public static class MessageDisplayer
    {
        const int ROW = 1;
        const int COL = 40;

        public static void Alert (string msg)
        {
            Console.SetCursorPosition(COL, ROW);
            Console.Write(msg);
        }
    }
}
