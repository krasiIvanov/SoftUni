using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePosition
{
    class Rectangle
    {
        public double Top { get; set; }
        public double Left { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public double Bottom
        {
            get
            {
                return this.Top + this.Height;
            }
        }
        public double Right
        {
            get
            {
                return this.Left + this.Width;
            }
        }

        public static Rectangle ReadRectangle()
        {
            double[] cordinats = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var rect = new Rectangle()
            {
                Top = cordinats[0],
                Left = cordinats[1],
                Width = cordinats[2],
                Height = cordinats[3]
            };
            return rect;
        }

        public override string ToString()
        {
            return String.Format("[Left={0}, Top={1}, Bottom={2}, Right={3}]", this.Left, this.Top, this.Bottom, this.Right);
        }

        public static bool IsFirstREctInside(Rectangle r1,Rectangle r2)
        {
            bool inside = 
                r1.Left <= r2.Left && 
                r2.Top >= r2.Top && 
                r2.Right <= r2.Right && 
                r1.Bottom <= r2.Bottom;

            return inside;
        }

    }//end class Rectangle
    class RectanglePosition
    {
        static void Main(string[] args)
        {
            var r1 = Rectangle.ReadRectangle();
            var r2 = Rectangle.ReadRectangle();
            if (Rectangle.IsFirstREctInside(r1,r2))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not Inside");
            }
        }
    }//end clas RecanglePosition
}
