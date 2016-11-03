using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        Random rnd = new Random();

        private char symbol;
        private int drawWidth;
        private int drawHeight;

        public FoodCreator(int drawWidth, int drawHeight, char symbol)
        {
            this.drawWidth = drawWidth;
            this.drawHeight = drawHeight;
            this.symbol = symbol;
        }

        public Point GenerateFood(Shape snake)
        {
            Point food;
            do
            {
                food = new Point(rnd.Next(2, drawWidth), rnd.Next(4, drawHeight), symbol);
            } while (snake.Hit(food));

            return food;
        }
    }
}
