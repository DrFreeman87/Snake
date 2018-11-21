using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> PList;

        public void DrawLine()
        {
            foreach (Point p in PList)
            {
                p.Draw();
            }
        }

    }
}
