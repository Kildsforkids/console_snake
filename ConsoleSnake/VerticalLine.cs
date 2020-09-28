using System.Collections.Generic;

namespace Figures
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int x, int y, int length, char sym)
        {
            pList = new List<Point>();

            for (int i = 0; i < length; i++)
            {
                pList.Add(new Point(x, y + i, sym));
            }
        }

        public void Draw()
        {
            foreach (var p in pList)
            {
                p.Draw();
            }
        }
    }
}
