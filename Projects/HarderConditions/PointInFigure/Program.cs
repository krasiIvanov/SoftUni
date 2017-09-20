using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInFigure
{
    class Program
    {
        static void Main(string[] args)
        {

            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (((x>0 && x<h*3)&& (y>0 && y<h))||((x>h && x<2*h)&&(y>h && y<4*h)))
            {
                Console.WriteLine("Inside");
            }
            else if ((x < 0 || x > h * 3) || (y < 0 || y > h) || (x < h || x > 3 * h ||  y > 4 * h))
            {
                Console.WriteLine("Outside");
            }
            else 
            {
                Console.WriteLine("Border");
            }

        }
    }
}
