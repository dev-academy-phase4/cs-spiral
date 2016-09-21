using System;

namespace Spiral
{
    public static class MessageDisplayer
    {
        const int ALERT_ROW = 1;
        const int ALERT_COL = 50;

        const int SAGACITY_ROW = 3;
        const int SAGACITY_COL = 50;

        const int GUILE_ROW = 4;
        const int GUILE_COL = 50;

        const int KINDNESS_ROW = 5;
        const int KINDNESS_COL = 50;

        public static void Alert (string msg)
        {
            Erase();
            Console.SetCursorPosition(ALERT_COL, ALERT_ROW);
            Console.Write(msg);
        }

        public static void Sagacity (int n)
        {
            Erase(SAGACITY_COL, SAGACITY_ROW);
            Console.SetCursorPosition(SAGACITY_COL, SAGACITY_ROW);
            Console.Write($"Sagacity: {n}");
        }

        public static void Guile (int n)
        {
            Erase(GUILE_COL, GUILE_ROW);
            Console.SetCursorPosition(GUILE_COL, GUILE_ROW);
            Console.Write($"Guile: {n}");
        }

        public static void Kindness (int n)
        {
            Erase(KINDNESS_COL, KINDNESS_ROW);
            Console.SetCursorPosition(KINDNESS_COL, KINDNESS_ROW);
            Console.Write($"Kindness: {n}");
        }

        private static void Erase (int col = ALERT_COL, int row = ALERT_ROW)
        {
            Console.SetCursorPosition(col, row);
            Console.Write(new string(' ', 50));
        }

    }
}
