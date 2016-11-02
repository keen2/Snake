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
        private int windowHeight;
        private int windowWidth;

        public FoodCreator(int windowWidth, int windowHeight, char symbol)
        {
            this.windowWidth = windowWidth;
            this.windowHeight = windowHeight;
            this.symbol = symbol;
        }

        public Point GenerateFood()
        {
            Point newFood = new Point(rnd.Next(windowWidth), rnd.Next(windowHeight), symbol);
            return newFood;
        }
    }
}
