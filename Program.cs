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
            Console.WindowWidth = 100;
            Console.WindowHeight = 40;

            // create a snake
            Snake snake = new Snake(new Point(13, 11, '*'), 4, Direction.Right);
            snake.Draw();

            // create initial food
            FoodCreator foodCreator = new FoodCreator(Console.WindowWidth, Console.WindowHeight, '$');
            Point food = foodCreator.GenerateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.GenerateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                
                Thread.Sleep(100);

                // if there is a key pressed
                if (Console.KeyAvailable)
                {
                    // set snake direction to it
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    snake.SetDirection(keyInfo.Key);

                    // exit on ESC
                    if (keyInfo.Key == ConsoleKey.Escape)
                        return;
                }
            }
        }
    }
}
