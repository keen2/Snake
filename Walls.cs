using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Shape> wallList;

        public Walls(int drawWidth, int drawHeight)
        {
            // create a frame that will clamp a snake inside the console window
            HorizontalLine topLine = new HorizontalLine(0, drawWidth, 0, '=');
            HorizontalLine bottomLine = new HorizontalLine(0, drawWidth, drawHeight, '=');
            VerticalLine leftLine = new VerticalLine(0, 0, drawHeight, '#');
            VerticalLine rightLine = new VerticalLine(drawWidth, 0, drawHeight, '#');

            // we can add VerticalLine, because it inherited from Shape class
            wallList = new List<Shape>();
            wallList.Add(topLine);
            wallList.Add(bottomLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        public bool Hit(Shape shape)
        {
            foreach (var wall in wallList)
                if (shape.Hit(wall))
                    return true;
            return false;
        }

        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            foreach (var wall in wallList)
            {
                wall.Draw();
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
