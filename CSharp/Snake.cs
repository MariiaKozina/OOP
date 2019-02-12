using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeTest
{
    class Snake:Object
    {
        Direction direction;
        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
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
               Point tail=pointList.First();
                pointList.Remove(tail);
                Point head = GetNextPoint();
                pointList.Add(head);

                tail.Clear();
                head.Draw();
            }
            public Point GetNextPoint()
            {
            Point head = pointList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
            }
        public bool IsHitTail()
        {
            var head = pointList.Last();
            for (int i= 0; i < pointList.Count - 2; i++)
            {
                if (head.IsHit(pointList[i]))
                    return true;
            }
            return false;
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.Left;
            if (key == ConsoleKey.RightArrow)
                direction = Direction.Right;
            if (key == ConsoleKey.DownArrow)
                direction = Direction.Down;
            if (key == ConsoleKey.UpArrow)
                direction = Direction.Up;
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pointList.Add(food);
                return true;
            }
            else
                return false;
        }
        }
    }

