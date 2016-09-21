using System;

namespace Spiral
{
    public class Monster : IDisplayableCreature
    {
        public int Row { get; private set; }
        public int Col { get; private set; }
        public int DisplayRow { get; set; }
        public int DisplayCol { get; set; }
        public char Avatar { get; set; }
        public ConsoleColor Color { get; set; }
        public bool Vanquished { get; set; }

        private int _width;

        public Monster (int row, int col, char avatar = 'M', int width = 2)
        {
            Row = row;
            DisplayRow = row;
            Col = col;
            DisplayCol = col > 0 ? col * width : 0;
            _width = width;
            Color = ConsoleColor.Blue;
            Avatar = avatar;
        }

        public void DisplayDefeatedForm ()
        {
            Color = ConsoleColor.DarkRed;
            Avatar = '*';
            Write();
        }

        public void Write ()
        {
            Console.SetCursorPosition(DisplayCol, DisplayRow);
            Console.ForegroundColor = Color;
            Console.Write(Avatar);
            Console.ResetColor();
        }
    }
}
