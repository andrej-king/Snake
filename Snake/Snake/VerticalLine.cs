﻿using System;
using System.Collections.Generic;

namespace Snake
{
    public class VerticalLine : Figure // : Extend
    {
        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            // List points
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}