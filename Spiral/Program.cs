﻿using System;
using System.Collections.Generic;

namespace Spiral
{
    internal class Program
    {
        private static Board NewLevel (int level)
        {
            Console.Clear();
            return new Board(MapLoader.LoadMap(level));
        }

        private static void Main(string[] args)
        {
            int currentLevel = 0;
            var board = new Board();

            string key = "";
            do
            {
                if (board.Exit == true)
                {
                    try
                    {
                        board = NewLevel(++currentLevel);
                        board.Exit = false;
                    }
                    catch(ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("An error prevented the game board from being created.");
                        Console.ReadLine();
                        return;
                    }

                    Console.CursorVisible = false;
                    BoardDisplayer.Output(board);
                }
                board.Update();
                key = Console.ReadKey(true).KeyChar.ToString();
                switch (key)
                {
                    case "w":
                        board.MovePlayer("n");
                        break;

                    case "s":
                        board.MovePlayer("s");
                        break;

                    case "a":
                        board.MovePlayer("w");
                        break;

                    case "d":
                        board.MovePlayer("e");
                        break;

                    case "x":
                        board.MovePlayer("x");
                        break;
                }
            } while (key != "q");
        }
    }
}
