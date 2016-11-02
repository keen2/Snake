using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    enum Dir2//////////////////////////////
    {
        Left2,
        Right2
    }
    class Program
    {
        static void Main(string[] args)
        {
            HorizontalLine line1 = new HorizontalLine(4, 8, 7, '#');
            line1.Draw();

            VerticalLine line2 = new VerticalLine(8, 8, 15, '%');
            line2.Draw();
            
            Snake snake = new Snake(new Point(13, 11, '*'), 4, Direction.Right);
            snake.Draw();

            Console.ReadLine();
        }
    }
}
