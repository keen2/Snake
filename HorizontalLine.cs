using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine
    {
        List<Point> pointList;

        public HorizontalLine(int x, int y, int length, char symbol)
        {
            pointList = new List<Point>();

            for (int i = 0; i < length; i++)
            {
                pointList.Add(new Point(x + i, y, symbol));
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
