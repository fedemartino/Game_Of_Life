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
            bool[,] rawBoard = BoardImporter.ImportBoard(boardPath); 
            Board board = new Board(rawBoard.GetLength(0), rawBoard.GetLength(1), rawBoard);
            IGameEngine gameOfLife = new GameOfLifeEngine(board);
            BoardPrinter printer = new BoardPrinter("|__", "|XX");
            
            for (int i = 0; i < 50; i++)
            {
                Console.Clear();
                Console.WriteLine(printer.PrintBoard(board));
                Thread.Sleep(300);
                gameOfLife.NextStep();
            }
        }
    }
}
