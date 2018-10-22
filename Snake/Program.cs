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
            Console.SetBufferSize(120, 30);

            //отрисовка рамочки
            Walls walls = new Walls(119, 28);
            walls.Draw();
            //HorizontalLine upLine = new HorizontalLine(0, 119, 0, '+');
            //HorizontalLine downLine = new HorizontalLine(0, 119, 28, '+');
            //VertikalLine leftLine = new VertikalLine(0, 28, 0, '+');
            //VertikalLine rightLine = new VertikalLine(0, 28, 119, '+');
            //upLine.Drow();
            //downLine.Drow();
            //leftLine.Drow();
            //rightLine.Drow();
            // отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            FoodCreator foodCreator = new FoodCreator(80, 26, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake)||snake.IsHitTail() )
                {
                    break;
                }
                
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();

                }
                else
                {
                    snake.Move();
                    
                }
                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key );
                }
                
                //snake.Move();


            }


           
            
           

            #region Lesson6


            //Point p3 = new Point(8, 10, '@');
            //Point p4 = new Point(11, 12, '$');
            //Point p5 = new Point(13, 13, '%');
            //Point p6 = new Point(44, 15, '^');

            //List<Point> pList = new List<Point>();
            //pList.Add(p1);
            //pList.Add(p2);
            //pList.Add(p3);
            //pList.Add(p4);
            //pList.Add(p5);
            //pList.Add(p6);
            //foreach (var item in pList)

            //{
            //    item.Draw();
            //}
            #endregion



            Console.ReadLine();

            #region lesson5


            //    int x = 1;
            //    Func1(x);
            //    Console.WriteLine("Func1.x = " + x);
            //    x = 1;
            //    Func2(x);
            //    Console.WriteLine("Func2.x = " + x);
            //    x = 1;
            //    Func3(x);
            //    Console.WriteLine("Func3.x = " + x);
            //    Point p1 = new Point(1, 3, '*');
            //    Move(p1, 10, 10);
            //    Console.WriteLine("Call Move. p1.x = " + p1.x + ", p1.y = " + p1.y);

            //    Point p2 = new Point(4, 5, '#');
            //    p1 = p2;
            //    p2.x = 8;
            //    p2.y = 8;
            //    Console.WriteLine("p1 = p2. p1.x = " + p1.x + "p1.y = " + p1.y + ", p2.x = " + p2.x + ", p2.y = " + p2.y);

            //    p1 = new Point(1, 1, '*');
            //    //Update(p1);
            //    Console.WriteLine("Call Update. p1.x = " + p1.x + ", p1.y = " + p1.y);

            //    Console.ReadLine();
            //}
            //public static void Func1(int value)
            //{

            //}
            //public static void Func2(int value)
            //{
            //    value++;
            //}
            //public static void Func3(int x)
            //{
            //    x++;
            //}
            //public static void Move(Point p, int dx, int dy)
            //{
            //    p.x += dx;
            //    p.y += dy;
            //}

            #endregion


        }

    }
}