using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Shape
    {
        public VerticalLine(int x, int yTop, int yBottom, char symbol)
        {
            pointList = new List<Point>();

            for (int y = yTop; y <= yBottom; y++)
            {
                pointList.Add(new Point(x, y, symbol));
            }
        }
    }
}
