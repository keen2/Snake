using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Point> pointList = new List<Point>();
            pointList.Add(new Point(1, 3, '*'));
            pointList.Add(new Point(4, 5, '#'));
            pointList.Add(new Point(7, 2, '@'));

            foreach (Point point in pointList)
            {
                point.Draw();
            }

            Console.ReadLine();
        }
    }
}
