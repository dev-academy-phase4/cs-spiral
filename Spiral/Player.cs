using System;

namespace Spiral
{
    public class Player
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public int DisplayRow { get; set; }
        public int DisplayCol { get; set; }

        private int _width;

        public Player (int width = 2)
        {
            Row = 0;
            DisplayRow = 0;
            Col = 0;
            DisplayCol = 0;
            _width = width;
        }

        public void Move (string direction)
        {
            switch (direction)
            {
                case "s":
                    Row++;
                    DisplayRow++;
                    break;

                case "e":
                    Col++;
                    DisplayCol += _width;
                    break;

                case "n":
                    Row--;
                    DisplayRow--;
                    break;

                case "w":
                    Col--;
                    DisplayCol -= _width;
                    break;

                case "se":
                    Row++;
                    DisplayRow++;
                    Col++;
                    DisplayCol += _width;
                    break;

                case "sw":
                    Row++;
                    DisplayRow++;
                    Col--;
                    DisplayCol -= _width;
                    break;

                case "ne":
                    Row--;
                    DisplayRow--;
                    Col++;
                    DisplayCol += _width;
                    break;

                case "nw":
                    Row--;
                    DisplayRow--;
                    Col--;
                    DisplayCol -= _width;
                    break;
            }
        }

        public void Write ()
        {
            Console.SetCursorPosition(DisplayCol, DisplayRow);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write('@');
            Console.ResetColor();
        }
    }
}
