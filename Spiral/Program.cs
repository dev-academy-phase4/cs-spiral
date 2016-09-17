using System;

namespace Spiral
{
    class Program
    {
        static void Main(string[] args)
        {
            var board = new Board(10, 10);
            board.Update();
            Console.Clear();
            Console.Write(board);

            string key = "";
            while((key = Console.ReadKey(true).KeyChar.ToString()) != "q")
            {
                Console.WriteLine(key);
                switch(key)
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
                board.Update();
                Console.Clear();
                Console.Write(board);
            }
        }
    }
}
