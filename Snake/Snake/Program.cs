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
            Point p1 = new Point(1, 3, '*');
            p1.Draw();


            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            List<int> NumList = new List<int>();
            NumList.Add(0);
            NumList.Add(1);
            NumList.Add(2);

            int x = NumList[0];
            int y = NumList[1];
            int z = NumList[2];

            foreach(int i in NumList)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
