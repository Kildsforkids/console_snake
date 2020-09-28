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

            //Console.ReadKey();

            Point p = new Point(2, 3, '*');
            p.Draw();

            Random rand = new Random();
            int x = rand.Next(5, 10);
            int y = rand.Next(5, 10);

            Point p2 = new Point(x, y, '@');
            p2.Draw();

            var dir = Direction.Right;

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();

                    switch (key.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            dir = Direction.Left;
                            break;
                        case ConsoleKey.RightArrow:
                            dir = Direction.Right;
                            break;
                        case ConsoleKey.UpArrow:
                            dir = Direction.Up;
                            break;
                        case ConsoleKey.DownArrow:
                            dir = Direction.Down;
                            break;
                    }
                }

                Thread.Sleep(100);
                p.Move(dir);
            }
            
            Console.ReadLine();
        }
    }
}
