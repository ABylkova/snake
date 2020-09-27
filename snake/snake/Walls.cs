using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

           //Отрисовка рамочки
           HorizontalLine upline = new HorizontalLine(0, 78, 0, '+');
           HorizontalLine downline = new HorizontalLine(0, 78, 24, '+');
           VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
           VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');

           wallList.Add(upline);
           wallList.Add(downline);
           wallList.Add(leftLine);
           wallList.Add(rightLine);
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
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
            foreach(var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
