using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenPoints
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public static Point ReadPoint()
        {
            double[] cordinates = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Point p = new Point() {X=cordinates[0],Y=cordinates[1] };

            return p;
        }

        public static double CalcDist(Point p1,Point p2)
        {
            double sideA = Math.Abs( p1.X - p2.X);
            double sideB = Math.Abs(p1.Y - p2.Y);
            double dist = Math.Sqrt((sideA * sideA) + (sideB * sideB));

            return dist;
        }



    }
    class Program
    {
        static void Main(string[] args)
        {

            Point p1 = Point.ReadPoint();
            Point p2 = Point.ReadPoint();
            double dist = Point.CalcDist(p1, p2);
            Console.WriteLine("{0:f3}",dist);

        }
    }
}
