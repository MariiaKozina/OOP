using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeTest
{
    class HorizontalLine: Object
    {
       
        public HorizontalLine(int xLeft,int xRight, int y, char sym)
        {
            pointList = new List<Point>();
            for (int x = xLeft; x < xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pointList.Add(p);
            }
       
        }
        
    }
}
