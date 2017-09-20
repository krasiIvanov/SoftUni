using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBox
{
   public class Box
    {
        private double lenght;
        private double width;
        private double height;

        public Box(double lenght,double width,double height)
        {
            this.Lenght = lenght;
            this.Width = width;
            this.Height = height;
        }

        public double Lenght
        {
            get
            {
                return this.lenght;
            }
            private set
            {
                if (value<=0)
                {
                    throw new ArgumentException($"{nameof(this.Lenght)} cannot be zero or negative.");
                }
                this.lenght = value;
            }
        }
        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Width)} cannot be zero or negative.");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Height)} cannot be zero or negative.");
                }
                this.height = value;
            }
        }

        public double SurfaceArea()
        {
            double area = (2 *this.lenght * this.width) + (2 * this.lenght * this.height) + (2 * this.width * this.height);
            return area;
        }
        public double Volume()
        {
            double volume = this.lenght * this.width * this.height;
            return volume;
        }
        public double LeteralSurfaceArea()
        {
            double area = (2 * this.lenght * this.height) + (2 * this.width * this.height);
            return area;
        }

        public override string ToString()
        {
            string result = $"Surface area - {this.SurfaceArea():f2}\r\n" +
                            $"Leteral Surface Area - {this.LeteralSurfaceArea():f2}\r\n" +
                            $"Volume - {this.Volume():f2}\r\n";
            return result;
        }

    }
}
