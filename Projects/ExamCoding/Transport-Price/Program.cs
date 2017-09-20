using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {


            int num = int.Parse(Console.ReadLine());
            var type = Console.ReadLine().ToLower();
            double price=0;
            if (type.Equals("day"))
            {
                if (num<20)
                {
                    price = num * 0.79 + 0.70;
                }
                else if (num>=20 && num < 100)
                {
                    price = num * 0.09;
                }
                else if (num >= 100)
                {
                    price = num * 0.06;
                }
            }
            else if (type.Equals("night"))
            {
                if (num < 20)
                {
                    price = num * 0.90 + 0.70;
                }
                else if (num >= 20 && num<100)
                {
                    price = num * 0.09;
                }
                else if (num>=100)
                {
                    price = num * 0.06;
                }

            }
            Console.WriteLine(Math.Round(price,2));

        }
    }
}
