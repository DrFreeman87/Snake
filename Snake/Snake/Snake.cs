using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        public Direction direction;

        public Snake(Point Tail, int Lenght, Direction _direction)
        {
            direction = _direction;
            PList = new List<Point>();
            for (int i = 0; i < Lenght; i++)
            {
                Point p = new Point(Tail);
                p.Move(i, direction);
                PList.Add(p);
            }
        }

        internal void Move()
        {
            Point Tail = PList.First();
            PList.Remove(Tail);
            Point Head = GetNextPoint();
            PList.Add(Head);

            Tail.Clear();
            Head.Draw();
        }

        public Point GetNextPoint()
        {
            Point Head = PList.Last();
            Point NextPoint = new Point(Head);
            NextPoint.Move(1, direction);
            return NextPoint;
        }
    }
}
