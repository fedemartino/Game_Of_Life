using System;
using System.Threading;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            string boardPath = @"..\..\board.txt";
            bool[,] board = BoardImporter.ImportBoard(boardPath); 
            Board b = new Board(board.GetLength(0), board.GetLength(1), board);
            Motor m = new Motor(b);
            Console.Clear();
            Console.WriteLine(BoardPrinter.PrintBoard(m.Board));
            Thread.Sleep(1000);
            Console.Clear();
            for (int i = 0; i < 50; i++)
            {
                m.NextStep();
                Console.Clear();
                Console.WriteLine(BoardPrinter.PrintBoard(m.Board));
                Thread.Sleep(300);
                
            }
        }
    }
}
