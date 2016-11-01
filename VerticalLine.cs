using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> pointList;

        public VerticalLine(int x, int y, int length, char symbol)
        {
            pointList = new List<Point>();

            for (int i = 0; i < length; i++)
            {
                pointList.Add(new Point(x, y + i, symbol));
            }
        }

        public void Draw()
        {
            foreach (Point point in pointList)
            {
                point.Draw();
            }
        }
    }
}
