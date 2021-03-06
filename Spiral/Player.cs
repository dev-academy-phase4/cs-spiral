﻿using System;

namespace Spiral
{
    public class Player : IDisplayableCreature
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public int DisplayRow { get; set; }
        public int DisplayCol { get; set; }
        public char Avatar { get; set; }
        public ConsoleColor Color { get; set; }
        public bool Vanquished { get; set; }

        private readonly int _width;

        public Player (int width = 2)
        {
            Row = 0;
            DisplayRow = 0;
            Col = 0;
            DisplayCol = 0;
            _width = width;
            Avatar = '@';
            Color = ConsoleColor.Red;
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

        public void Vanquish (IDisplayableCreature monster)
        {
            monster.Vanquished = true;
            monster.DisplayDefeatedForm();
            MessageDisplayer.Alert("You vanquished the monster!");
        }

        public void DisplayDefeatedForm ()
        {
            Color = ConsoleColor.DarkRed;
            Avatar = '!';
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
