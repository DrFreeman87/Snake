using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            
            HorizontalLine LineUp = new HorizontalLine(1, Console.BufferWidth - 1, 1, '+');
            LineUp.DrawLine();

            HorizontalLine LineDown = new HorizontalLine(1, Console.BufferWidth - 1, 23, '+');
            LineDown.DrawLine();

            VerticalLine LineLeft = new VerticalLine(1, 23, 1, '+');
            LineLeft.DrawLine();

            VerticalLine LineRight = new VerticalLine(1, 23, Console.BufferWidth - 2, '+');
            LineRight.DrawLine();

            Console.ReadLine();
        }
    }
}
