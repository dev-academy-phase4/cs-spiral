﻿using System;
using System.Collections.Generic;

namespace Spiral
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] map = MapLoader.LoadMap();

            Board board;
            try
            {
                board = new Board(map);
            }
            catch(System.ArgumentOutOfRangeException)
            {
                Console.WriteLine("An error prevented the game board from being created.");
                Console.ReadLine();
                return;
            }

            string key = "";
            do
            {
                board.Update();
                Console.Clear();
                BoardDisplayer.Output(board.ToString());

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
                }
            } while (key != "q");
        }
    }
}
