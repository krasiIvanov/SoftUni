using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstTokens = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int numberOfRectangles = firstTokens[0];
            int numberOfChecks = firstTokens[1];

            Dictionary<string, Rectangle> rectangles = new Dictionary<string, Rectangle>();

            for (int i = 0; i < numberOfRectangles; i++)
            {
                string[] rectanglestokens = Console.ReadLine().Split();
                string id = rectanglestokens[0];
                int width = int.Parse(rectanglestokens[1]);
                int height = int.Parse(rectanglestokens[2]);
                double[] topLeftCord = new double[] {double.Parse(rectanglestokens[3]), double.Parse(rectanglestokens[4]) };

                Rectangle newRectangle = new Rectangle(id, width, height, topLeftCord);

                rectangles.Add(id, newRectangle);

            }

            for (int i = 0; i < numberOfChecks; i++)
            {
                string[] ids = Console.ReadLine().Split();

                bool result= Rectangle.Intersect(rectangles[ids[0]], rectangles[ids[1]]);
                Console.WriteLine(result);

            }
        }
    }
}
