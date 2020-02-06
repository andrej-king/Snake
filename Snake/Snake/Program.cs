using System;
using System.Collections.Generic;

namespace Snake
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            // p1.Draw(); // draw point

            Point p2 = new Point(4, 5, '#');
            // p2.Draw();

            Point p3 = new Point(3, 4, '^');
            // p3.Draw();
            
            Point p4 = new Point(12, 2, '+');
            // p4.Draw();
            

            Console.WriteLine();

            // Create list
            // List<int> numList = new List<int>();
            // numList.Add(1);
            // numList.Add(2);
            // numList.Add(3);
            //
            // foreach (int i in numList)
            // {
            //     Console.WriteLine(i);
            // }

            // remove item with index 0
            // numList.RemoveAt(0);


            // List points
            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);
            
            // Draw points with foreach
            foreach (var VARIABLE in pList)
            {
                VARIABLE.Draw();
            }
            
            
            Console.ReadKey();
        }
    }
}