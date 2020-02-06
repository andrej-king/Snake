using System.Collections.Generic;

namespace Snake
{
    public class Figure
    {
        protected List<Point> pList;

        // Draw points with foreach
        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}