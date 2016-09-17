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
                switch(key)
                {
                }
                board.Update();
                Console.Clear();
                Console.Write(board);
            }
        }
    }
}
