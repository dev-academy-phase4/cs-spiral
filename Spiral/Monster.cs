using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiral
{
    public class Monster : IDisplayableCreature
    {
        public int Row { get; private set; }
        public int Col { get; private set; }
        public int DisplayRow { get; set; }
        public int DisplayCol { get; set; }
        public char Avatar { get; }
        public ConsoleColor Color { get; }

        private int _width;

        public Monster (int row, int col, char avatar = 'M', int width = 2)
        {
            Row = row;
            DisplayRow = row;
            Col = col;
            DisplayCol = col;
            _width = width;
            Color = ConsoleColor.Blue;
            Avatar = avatar;
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
