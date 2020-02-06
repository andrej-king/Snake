using System;

namespace Snake
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw(); // draw point

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Console.ReadKey();
        }
    }
}