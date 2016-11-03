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
            const int ConsoleWidth = 80;
            const int ConsoleHeight = 40;

            // set window size
            Console.WindowWidth = ConsoleWidth;
            Console.WindowHeight = ConsoleHeight;
            // and the same buffer to input/output
            Console.SetBufferSize(ConsoleWidth, ConsoleHeight);

            // create walls
            Walls walls = new Walls(ConsoleWidth - 2, ConsoleHeight - 1);
            walls.Draw();

            // create a snake
            Snake snake = new Snake(new Point(13, 11, '*'), 4, Direction.Right);
            snake.Draw();

            // create initial food
            FoodCreator foodCreator = new FoodCreator(ConsoleWidth - 4, ConsoleHeight - 3, '$');
            Point food = foodCreator.GenerateFood();
            food.Draw();

            int snakeSpeed = 0;
            int level = 1;
            DrawLevel(level);

            while (true)
            {
                // if snake meets wall or itself
                if (walls.Hit(snake) || snake.HitTail())
                {
                    Console.SetCursorPosition((ConsoleWidth - "GAME OVER!".Count())/2, ConsoleHeight / 3);
                    Console.Write("GAME OVER!");
                    Console.SetCursorPosition(ConsoleWidth / 3, ConsoleHeight * 2 / 3);
                    Console.Write("Made by Andrey Ermishin.");
                    break;
                }

                // if snake eats a food - generate a new one, else - snake moves on
                if (snake.Eat(food))
                {
                    food = foodCreator.GenerateFood();
                    food.Draw();

                    // increase level and speed
                    level++;
                    if (snakeSpeed <= 130)
                        snakeSpeed += 10;
                }
                else
                {
                    snake.Move();
                }

                DrawLevel(level);

                Thread.Sleep(150 - snakeSpeed); //150..20

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

            Console.ReadLine();
        }

        private static void DrawLevel(int level)
        {
            Console.SetCursorPosition(Console.WindowWidth - 12, 1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Level: " + level);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
