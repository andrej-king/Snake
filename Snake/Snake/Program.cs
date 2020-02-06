using System;
using System.Collections.Generic;
using Snake.Properties;

namespace Snake
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');

            Point p2 = new Point(4, 5, '#');

            Point p3 = new Point(3, 4, '^');

            Point p4 = new Point(12, 2, '+');

            Console.WriteLine();

            HorizontalLine line = new HorizontalLine(5, 10, 8, '+');
            line.Draw();
            
            VerticalLine vLine = new VerticalLine( 3, 7, 20,'*');
            vLine.Draw();


            Console.ReadLine();
        }
    }
}