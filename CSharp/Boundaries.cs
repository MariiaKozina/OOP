using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeTest
{
    class Boundaries
    {
        List<Object> boundariesList;

        public Boundaries(int mapWidth, int mapHeight)
        {
            boundariesList = new List<Object>();

            // Отрисовка рамочки
            HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
            VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+');

            boundariesList.Add(upLine);
            boundariesList.Add(downLine);
            boundariesList.Add(leftLine);
            boundariesList.Add(rightLine);
        }

        internal bool IsHit(Object figure)
        {
            foreach (var wall in boundariesList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in boundariesList)
            {
                wall.Draw();
            }
        }
    }
}
