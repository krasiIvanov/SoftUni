using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine().ToLower();
            double count = double.Parse(Console.ReadLine());

           

            if (city.Equals("sofia"))
            {
                if (product.Equals("coffee"))
                {
                    Console.WriteLine(count*0.5);
                }
                else if (city.Equals("water"))
                {
                    Console.WriteLine(count*0.8);
                }
                else if (product.Equals("beer"))
                {
                    Console.WriteLine(count*1.20);
                }
                else if (product.Equals("sweets"))
                {
                    Console.WriteLine(count*1.45);
                }
                else if (product.Equals("peanuts"))
                {
                    Console.WriteLine(count*1.60);
                }
            }
            else if (city.Equals("plovdiv"))
            {
                if (product.Equals("coffee"))
                {
                    Console.WriteLine(count * 0.4);
                }
                else if (city.Equals("water"))
                {
                    Console.WriteLine(count * 0.7);
                }
                else if (product.Equals("beer"))
                {
                    Console.WriteLine(count * 1.15);
                }
                else if (product.Equals("sweets"))
                {
                    Console.WriteLine(count * 1.30);
                }
                else if (product.Equals("peanuts"))
                {
                    Console.WriteLine(count * 1.50);
                }
            }
            else if (city.Equals("varna"))
            {
                if (product.Equals("coffee"))
                {
                    Console.WriteLine(count * 0.45);
                }
                else if (city.Equals("water"))
                {
                    Console.WriteLine(count * 0.7);
                }
                else if (product.Equals("beer"))
                {
                    Console.WriteLine(count * 1.15);
                }
                else if (product.Equals("sweets"))
                {
                    Console.WriteLine(count * 1.30);
                }
                else if (product.Equals("peanuts"))
                {
                    Console.WriteLine(count * 1.55);
                }
            }

        }
    }
}
