using System.Text;

namespace GameOfLife
{
    public class BoardPrinter
    {
        public static string PrintBoard(Board b)
        {
            StringBuilder s = new StringBuilder();
            for (int y = 0; y<b.Height;y++)
            {
                for (int x = 0; x<b.Width; x++)
                {
                    if(b.GetValue(x,y))
                    {
                        s.Append("|0|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }
            return s.ToString();
        }
    }
}