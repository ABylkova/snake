using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yUp, int YDown, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= YDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

     }
}
