using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionOfCircles
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }


    }

    class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }
        

        public static Circle ReadCircle()
        {
            double[] tokens = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var cordinats = new Point() { X = tokens[0], Y = tokens[1] };
            var newCircle = new Circle() { Center=cordinats,Radius=tokens[2] };

            return newCircle;
        }

        public static double Daimetar(Circle c1,Circle c2)
        {
            double witdh = c1.Center.X - c2.Center.X;
            double height = c1.Center.Y - c2.Center.Y;
            double d = Math.Sqrt((witdh * witdh) + (height * height));

            return d;
        }

        public static bool Intersect(Circle c1 ,Circle c2)
        {
            double d = Daimetar(c1, c2);
            if (d<=c1.Radius+c2.Radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var firstCirle = Circle.ReadCircle();
            var secondCircle = Circle.ReadCircle();
            if (Circle.Intersect(firstCirle,secondCircle))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
