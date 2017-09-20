using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Tycoon
{
    class Program
    {
        static void Main(string[] args)
        {

            
            ulong cakes = ulong.Parse(Console.ReadLine());
            decimal kgFlourNeeded = decimal.Parse(Console.ReadLine());
            uint totalFlour = uint.Parse(Console.ReadLine());
            ulong truffles = ulong.Parse(Console.ReadLine());
            ulong trufflePrice = ulong.Parse(Console.ReadLine());

            ulong amountCakes = (ulong)(totalFlour / kgFlourNeeded);
            decimal truffleCost = truffles * trufflePrice;
            decimal priceOfCakes = (truffleCost/cakes)*(decimal)1.25;
            decimal kgLeft = Math.Abs((cakes * kgFlourNeeded) - totalFlour);

            if (amountCakes >= cakes)
            {
                Console.WriteLine("All products available, price of a cake: {0:f2}", priceOfCakes);
            }
            else
            {
                Console.WriteLine("Can make only {0} cakes, need {1:f2} kg more flour",amountCakes,kgLeft);
            }

        }
    }
}
