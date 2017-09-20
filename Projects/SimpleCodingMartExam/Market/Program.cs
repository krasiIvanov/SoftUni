using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    class Program
    {
        static void Main(string[] args)
        {


            double priceVegitable = double.Parse(Console.ReadLine());
            double priceFruits = double.Parse(Console.ReadLine());
            double kgVegitable = double.Parse(Console.ReadLine());
            double kgFruits = double.Parse(Console.ReadLine());

            double totalPriceFruits = priceFruits * kgFruits;
            double totalPriceVagitables = priceVegitable * kgVegitable;
            double total = (totalPriceFruits + totalPriceVagitables) / 1.94;
            Console.WriteLine(total);

        }
    }
}
