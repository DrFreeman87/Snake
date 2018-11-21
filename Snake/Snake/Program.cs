using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Отрисовка рамки
            HorizontalLine LineUp = new HorizontalLine(1, 80 - 1, 1, '+');
            HorizontalLine LineDown = new HorizontalLine(1, 80 - 1, 23, '+');
            VerticalLine LineLeft = new VerticalLine(1, 23, 1, '+');
            VerticalLine LineRight = new VerticalLine(1, 23, 80 - 2, '+');
            LineRight.DrawLine();
            LineLeft.DrawLine();
            LineUp.DrawLine();
            LineDown.DrawLine();

            //Отрисовка точки
            Point p = new Point(5, 6, '*');
            Snake snake1 = new Snake(p, 4, Direction.RIGHT);

            snake1.DrawLine();

            //Создаем еду
            FoodCreator foodCreator = new FoodCreator(40, 23, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();


            //Движение змейки
            while (true)
            {
                if (snake1.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                    snake1.Move();
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.LeftArrow)
                    {
                        snake1.direction = Direction.LEFT;
                    }
                    else if (key.Key == ConsoleKey.RightArrow)
                    {
                        snake1.direction = Direction.RIGHT;
                    }
                    else if (key.Key == ConsoleKey.UpArrow)
                    {
                        snake1.direction = Direction.UP;
                    }
                    else if (key.Key == ConsoleKey.DownArrow)
                    {
                        snake1.direction = Direction.DOWN;
                    }
                }
                Thread.Sleep(200);
                snake1.Move();
            }


            Console.ReadLine();
        }
    }
}
