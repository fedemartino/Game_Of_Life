namespace GameOfLife
{
    public class GameOfLifeEngine : IGameEngine
    {
        public Board Board {get;private set;}
        private Board cloneboard;
        public GameOfLifeEngine(Board board)
        {
            this.Board = board;
            this.cloneboard = new Board(board.Height,board.Height);
        }
        public void NextStep()
        {
            for (int x = 0; x < this.Board.Width; x++)
            {
                for (int y = 0; y < this.Board.Height; y++)
                {
                    int aliveNeighbors = 0;
                    for (int i = x-1; i<=x+1;i++)
                    {
                        for (int j = y-1;j<=y+1;j++)
                        {
                            if(i>=0 && i<this.Board.Width && j>=0 && j <this.Board.Height && this.Board.GetValue(i,j))
                            {
                                aliveNeighbors++;
                            }
                        }
                    }
                    if(this.Board.GetValue(x,y))
                    {
                        aliveNeighbors--;
                    }
                    if (this.Board.GetValue(x,y) && aliveNeighbors < 2) 
                    {
                        //Cell is lonely and dies 
                        this.cloneboard.SetValue(x,y,false); 
                    }
                    else if (this.Board.GetValue(x,y) && aliveNeighbors > 3) 
                    {
                        //Cell dies due to over population 
                        this.cloneboard.SetValue(x,y,false);
                    }
                    else if (!this.Board.GetValue(x,y) && aliveNeighbors == 3) 
                    {
                        //A new cell is born 
                        this.cloneboard.SetValue(x,y,true);
                    }
                    else
                    {
                        //Remains the same
                        this.cloneboard.SetValue(x,y,this.Board.GetValue(x,y));
                    }
                }
            }
            CopyToBoard(this.cloneboard, this.Board);
            this.cloneboard = new Board(this.Board.Width, this.Board.Height);
        }
        private void CopyToBoard(Board fromBoard, Board toBoard)
        {
            for (int x = 0; x < fromBoard.Width; x++)
            {
                for (int y = 0; y < fromBoard.Height; y++)
                {
                    toBoard.SetValue(x, y, fromBoard.GetValue(x, y));
                }
            }
        }
    }
}