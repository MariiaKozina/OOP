using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeTest
{
    class Object
    {
        protected List<Point> pointList;

        public virtual void Draw()
        {
            foreach (Point p in pointList)
            {
                p.Draw();
            }


        }
        internal bool IsHit(Object figure)
        {
            foreach (var p in pointList)
            {
                if (figure.IsHit(p))
                    return true;
            }
            return false;
        }

        private bool IsHit(Point point)
        {
            foreach (var p in pointList)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }
    }
}
