using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleIntersection
{
    class Rectangle
    {

        private string id;
        private int width;
        private int height;
        private double[] topLeftCord;

        public Rectangle(string id,int width,int height, double[] topLeftCord)
        {
            this.Id = id;
            this.Width = width;
            this.Height = height;
            this.TopLeftCord = new double[] {topLeftCord[0],topLeftCord[1] };
        }

        public static bool Intersect(Rectangle r1,Rectangle r2)
        {
            bool isIntersect = false;

            if (Math.Abs(r1.TopLeftCord[0]) < Math.Abs(r2.TopLeftCord[0] + r2.width))
            {
                if (Math.Abs(r1.TopLeftCord[0] + r1.width) >= Math.Abs(r2.TopLeftCord[0]))
                {
                    if (r1.TopLeftCord[1] < Math.Abs((r2.TopLeftCord[1] - r2.height)))
                    {
                        if (Math.Abs(r1.TopLeftCord[1] + r1.height) >= Math.Abs(r2.TopLeftCord[1]))
                        {
                            isIntersect = true;
                        }
                    }
                }
            }

            return isIntersect;
        }

        public string Id { get => id; set => id = value; }
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
        public double[] TopLeftCord { get => topLeftCord; set => topLeftCord = value; }


    }
}
