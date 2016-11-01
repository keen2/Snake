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
            HorizontalLine line1 = new HorizontalLine(4, 7, 8, '#');
            line1.Draw();

            VerticalLine line2 = new VerticalLine(11, 8, 5, '%');
            line2.Draw();

            Console.ReadLine();
        }
    }
}
