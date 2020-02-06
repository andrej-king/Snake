using System;
using System.IO;

namespace Snake
{
    public class Point
    {
        public int x;
        public int y;
        public char sym;

        // Constructor
        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y); // Cursor position
            Console.Write(sym); // draw symbol
        }
    }
}