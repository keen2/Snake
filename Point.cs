using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char symbol;

        public Point()
        {
        }
        public Point(int x, int y, char symbol)
        {
            this.x = x;
            this.y = y;
            this.symbol = symbol;
        }
        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
            this.symbol = p.symbol;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
        public void Draw(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Clear()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(' ');
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.Left)
                x -= offset;
            else if (direction == Direction.Right)
                x += offset;
            else if (direction == Direction.Down)
                y += offset;
            else
                y -= offset;
        }

        public bool Hits(Point food)
        {
            return this.x == food.x && this.y == food.y;
        }
    }
}
