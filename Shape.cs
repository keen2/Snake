using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Shape
    {
        protected List<Point> pointList;

        public void Draw()
        {
            foreach (Point point in pointList)
            {
                point.Draw();
            }
        }

        public bool Hit(Shape otherShape)
        {
            foreach (Point pThis in pointList)
                if (otherShape.Hit(pThis))
                    return true;
            return false;
        }

        private bool Hit(Point pThis)
        {
            foreach (Point pOther in pointList)
                if (pOther.Hits(pThis))
                    return true;
            return false;
        }
    }
}
