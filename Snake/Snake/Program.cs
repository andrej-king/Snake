﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using Snake.Properties;

namespace Snake
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Console.SetBufferSize(80, 25);  // Set width and height window
            
            // Draw box
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine( 0, 24, 0,'+');
            VerticalLine rightLine = new VerticalLine( 0, 24, 78,'+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            
            // draw points
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            for (int i = 0; i < 20; i++)
            {
                snake.Move();
                Thread.Sleep(300);    
            }

            Console.ReadKey();

        }
    }
}