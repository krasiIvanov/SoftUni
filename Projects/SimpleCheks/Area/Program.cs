using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {

            string figure = Console.ReadLine().ToLower();
            double num = double.Parse(Console.ReadLine());

            if (figure.Equals("rectangle"))
            {
                double num2 = double.Parse(Console.ReadLine());
                Console.WriteLine(num*num2);
            }
            else if (figure.Equals("triangle"))
            {
                double h = double.Parse(Console.ReadLine());
                double triangleArea = (num * h) / 2;
                Console.WriteLine(triangleArea);

            }
            else if(figure.Equals("circle"))
            {
                double circleArea = Math.Round(Math.PI*Math.Pow(num,2),3);
                Console.WriteLine(circleArea);
            }
            else if (figure.Equals("square"))
            {
                Console.WriteLine(num*num);
            }

        }
    }
}
