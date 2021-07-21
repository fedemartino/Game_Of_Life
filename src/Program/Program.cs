using System;
using System.Threading;
using System.IO;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            string boardPath = Path.Combine("..", "..","board.txt");
            bool[,] board = BoardImporter.ImportBoard(boardPath); 
            Board b = new Board(board.GetLength(0), board.GetLength(1), board);
            Motor m = new Motor(b);
            BoardPrinter p = new BoardPrinter("|__", "|XX");
            
            for (int i = 0; i < 50; i++)
            {
                Console.Clear();
                Console.WriteLine(p.PrintBoard(m.Board));
                Thread.Sleep(300);
                m.NextStep();
                
            }
        }
    }
}
