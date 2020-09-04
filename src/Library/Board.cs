using System;

namespace GameOfLife
{
    public class Board
    {
        bool[,] board;
        public int Width {get;private set;}
        public int Height {get;private set;}
        public Board(int width, int height, bool[,] board=null)
        {
            this.Width = width;
            this.Height = height;
            if (board == null)
            {
                this.board = new bool[width,height];
            }
            else
            {
                this.board = board;
            }
        }
        public void SetValue(int x, int y, bool alive)
        {
            this.board[x,y] = alive;
        }
        public bool GetValue(int x, int y)
        {
            return this.board[x,y];
        }
    }
}
