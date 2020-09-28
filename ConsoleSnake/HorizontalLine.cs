using System.Collections.Generic;

namespace Figures
{
    class HorizontalLine
    {
        List<Point> pList;

        public HorizontalLine(int x, int y, int length, char sym)
        {
            pList = new List<Point>();

            for (int i = 0; i < length; i++)
            {
                pList.Add(new Point(x + i, y, sym));
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
