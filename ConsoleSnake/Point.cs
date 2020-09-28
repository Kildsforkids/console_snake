using System;

namespace Figures
{
    class Point
    {
        int x;
        int y;
        char sym;

        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public void Clear()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(' ');
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Move()
        {
            Clear();
            x++;
            Draw();
        }
    }
}
