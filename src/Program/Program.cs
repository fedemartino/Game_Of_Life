using System;
using System.Threading;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] board = new bool[5,5] {
                {true,false,false,false,false},
                {false,true,true,false,false},
                {true,true,false,false,false},
                {false,false,false,false,false},
                {false,false,false,false,false}
            };
            Board b = new Board(5, 5, board);
            Motor m = new Motor(b);
            Console.Clear();
            Console.WriteLine(BoardPrinter.PrintBoard(m.Board));
            Thread.Sleep(1000);
            Console.Clear();
            for (int i = 0; i < 10; i++)
            {
                m.NextStep();
                Console.WriteLine(BoardPrinter.PrintBoard(m.Board));
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}
