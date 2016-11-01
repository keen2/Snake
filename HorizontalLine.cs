using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Shape
    {
        public HorizontalLine(int xLeft, int xRight, int y, char symbol)
        {
            pointList = new List<Point>();

            for (int x = xLeft; x <= xRight; x++)
            {
                pointList.Add(new Point(x, y, symbol));
            }
        }
    }
}
