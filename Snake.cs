﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Shape
    {
        Direction direction;

        public Snake(Point tail, int length, Direction direction)
        {
            this.direction = direction;

            pointList = new List<Point>();

            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pointList.Add(p); 
            }
        }

        public void Move()
        {
            Point tail = pointList.First();
            pointList.Remove(tail);
            tail.Clear();

            Point head = GetNextPoint();
            pointList.Add(head);
            head.Draw();
        }

        private Point GetNextPoint()
        {
            // create copy of head point and move it
            Point newHead = new Point( pointList.Last() );
            newHead.Move(1, direction);
            return newHead;
        }

        public void SetDirection(ConsoleKey key)
        {
            if (key == ConsoleKey.RightArrow)
                direction = Direction.Right;
            else if (key == ConsoleKey.LeftArrow)
                direction = Direction.Left;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.Down;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.Up;
        }
    }
}
