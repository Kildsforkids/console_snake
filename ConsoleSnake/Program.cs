using Figures;
using System;
using System.Threading;

namespace ConsoleSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            HorizontalLine hLine = new HorizontalLine(0, 0, 16, '#');
            HorizontalLine hLine2 = new HorizontalLine(0, 10, 16, '#');
            hLine.Draw();
            hLine2.Draw();

            VerticalLine vLine = new VerticalLine(0, 0, 10, '#');
            VerticalLine vLine2 = new VerticalLine(15, 0, 10, '#');
            vLine.Draw();
            vLine2.Draw();

            Point p = new Point(2, 3, '*');
            p.Draw();

            while (true)
            {
                Thread.Sleep(100);
                p.Move();
            }
            
            Console.ReadLine();
        }
    }
}
