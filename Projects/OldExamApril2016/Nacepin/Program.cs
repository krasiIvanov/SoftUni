using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nacepin
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal priceUS = decimal.Parse(Console.ReadLine());
            uint weightUS = uint.Parse(Console.ReadLine());
            decimal priceUK = decimal.Parse(Console.ReadLine());
            uint weightUK= uint.Parse(Console.ReadLine());
            decimal priceCHI = decimal.Parse(Console.ReadLine());
            uint weightCHI = uint.Parse(Console.ReadLine());

            decimal shopUS = (priceUS / (decimal)0.58)/weightUS;

            decimal shopUK = (priceUK / (decimal)0.41)/weightUK;

            decimal shopCHI = (priceCHI * (decimal)0.27)/weightCHI;

            decimal min = Math.Min(shopUS, Math.Min(shopUK, shopCHI));
            decimal max = Math.Max(shopUS, Math.Max(shopUK, shopCHI));

            decimal saved = max - min;

            if (shopUS<shopUK && shopUS<shopCHI)
            {
                Console.WriteLine("US store. {0:f2} lv/kg",shopUS);
                Console.WriteLine("Difference {0:f2} lv/kg", saved);
            }
            else if (shopUK<shopUS && shopUK<shopCHI)
            {
                Console.WriteLine("UK store. {0:f2} lv/kg", shopUK);
                Console.WriteLine("Difference {0:f2} lv/kg", saved);
            }
            else if (shopCHI<shopUK && shopCHI<shopUS)
            {
                Console.WriteLine("Chinese store. {0:f2} lv/kg", shopCHI);
                Console.WriteLine("Difference {0:f2} lv/kg",saved);
            }
        }
    }
}
