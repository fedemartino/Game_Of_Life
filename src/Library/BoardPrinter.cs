using System.Text;

namespace GameOfLife
{
    public class BoardPrinter
    {
        public string DeadCell {get;set;}
        public string LiveCell {get;set;}
        public BoardPrinter(string deadCell = "___", string liveCell = "|X|")
        {
            DeadCell = deadCell;
            LiveCell = liveCell;
        }
        public string PrintBoard(Board b)
        {
            StringBuilder s = new StringBuilder();
            for (int y = 0; y<b.Height;y++)
            {
                for (int x = 0; x<b.Width; x++)
                {
                    if(b.GetValue(x,y))
                    {
                        s.Append(LiveCell);
                    }
                    else
                    {
                        s.Append(DeadCell);
                    }
                }
                s.Append("\n");
            }
            return s.ToString();
        }
    }
}