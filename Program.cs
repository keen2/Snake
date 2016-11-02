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
            Snake snake = new Snake(new Point(13, 11, '*'), 4, Direction.Right);
            snake.Draw();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    snake.SetDirection(keyInfo.Key);
                    if (keyInfo.Key == ConsoleKey.Escape)
                        return;
                }

                snake.Move();
                Thread.Sleep(100);
            }

            Console.ReadLine();
        }
    }
}
