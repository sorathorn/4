using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            float x1, x2, y1, y2, dx, dy, step;
            Console.WriteLine("Input floats x1, y1, x2 and y2: ");
            x = float.Parse(Console.ReadLine());
            y = float.Parse(Console.ReadLine());
            dx = X2 - X1;
            dY = y2 - y1;
            
            if (Math.Abs(dx) < Math.Abs(dy))
            {
                i = 1;
                dx = dx / step;
                dy = dy / step;
                x = x1;
                y = y1;
                while (i <= step)
                {
                    x = x + dx;
                    y = y + dy;
                    i++;
                }
                Console.WriteLine("");
                if (i > step)
                {
                    Console.WriteLine("");
                }
            }
            else
            {
                i = 1
                step = abs(dx);
                dx = dx / step;
                dy = dy / step;
                x = x1;
                y = y1;
                while (i <= step)
                {
                    x = x + dx;
                    y = y + dy;
                    i++;
                }
                Console.WriteLine("");
                if (i > step)
                {
                    Console.WriteLine("");
                }
            }
        }
    }
}
