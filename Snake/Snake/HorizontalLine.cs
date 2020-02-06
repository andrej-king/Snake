using System.Collections.Generic;

namespace Snake.Properties
{
    public class HorizontalLine : Figure // : Extend
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            // List points
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}