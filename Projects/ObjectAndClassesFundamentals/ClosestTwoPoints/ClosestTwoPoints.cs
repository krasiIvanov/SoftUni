using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestTwoPoints
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public static Point ReadPoint()
        {
            double[] cord = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Point p = new Point() { X = cord[0], Y = cord[1] };

            return p;
        }

        public static double CalcDist(Point p1, Point p2)
        {
            double sideA = Math.Abs(p1.X - p2.X);
            double sideB = Math.Abs(p1.Y - p2.Y);
            double dist = Math.Sqrt((sideA * sideA) + (sideB * sideB));

            return dist;
        }

        public override string ToString()
        {
            return string.Format("({0}, {1})",this.X,this.Y);
        }

        public static Point[] ReadArrayOfPoints()

        {
            int n = int.Parse(Console.ReadLine());
            var points = new Point[n];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = Point.ReadPoint();
            }

            return points;
        }

    }//end class Point

    class ClosestTwoPoints
    {
        static void Main(string[] args)
        {
            var points = Point.ReadArrayOfPoints();
            var nearPoints = FindNearestPoints(points);
            Console.WriteLine("{0:f3}",Point.CalcDist(nearPoints[0],nearPoints[1]));
            Console.WriteLine(nearPoints[0]);
            Console.WriteLine(nearPoints[1]);

        }

        private static Point[] FindNearestPoints(Point[] points)
        {
            var minDist = double.MaxValue;
            Point[] bestPoint = null;
            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i+1; j < points.Length; j++)
                {
                    var p1 = points[i];
                    var p2 = points[j];
                    var dist = Point.CalcDist(p1, p2);
                    if (dist<minDist)
                    {
                        minDist = dist;
                        bestPoint = new Point[] { p1, p2 };
                    }
                }
            }
            return bestPoint;
        }
    }
}//end namespace
