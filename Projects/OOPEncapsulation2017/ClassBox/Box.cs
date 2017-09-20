using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBox
{
    class Box
    {
        //length, width and height
        private double length;
        private double width;
        private double height;

        

        public Box(double length, double width, double height)
        {

            this.Length = length;
            this.Width = width;
            this.Height = height;

        }

        //surface area, lateral surface area and its volume 
        public double SurfaceArea()
        {
            double result = (2d * this.length * this.width) + (2d * this.length * this.height) + (2d * this.width * this.height);

            return result;
        }

        public double LeteralSurfaceArea()
        {
            double result = (2d * this.length * this.height) + (2d * this.width * this.height);

            return result;
        }

        public double Volume()
        {
            double result = this.length * this.width * this.height;

            return result;
        }

        private double Length
        {
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException($"{nameof(this.Length)} cannot be zero or negative. ");
                }
                this.length = value;
            }
        }
        private double Width
        {
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException($"{nameof(this.Width)} cannot be zero or negative. ");
                }
            }
        }
        private double Height
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Height)} cannot be zero or negative. ");
                }
            }
        }

    }
}
