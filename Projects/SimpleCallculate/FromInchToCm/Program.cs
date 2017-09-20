using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromInchToCm
{
    class Program
    {
        static void Main(string[] args)
        {
            double c = double.Parse(Console.ReadLine());
            string valutsType = Console.ReadLine();
            string convertValute= Console.ReadLine();


            double dolarsToBgrl = Math.Round(c* 1.79549,2);
            double dolarsToEuro = Math.Round((c * 1.79549)/1.95583, 2);
            double dolarsToGbp = Math.Round((c * 1.79549)/ 2.53405, 2);

            double euroToBgrl = Math.Round(c * 1.95583, 2);
            double euroToDolars = Math.Round((c * 1.95583)/ 1.79549, 2);
            double euroToGbp = Math.Round((c * 1.95583)/ 2.53405, 2);


            double gbpToBgrl = Math.Round(c * 2.53405, 2);
            double gbpToDolars = Math.Round((c * 2.53405) / 1.79549, 2);
            double gbpToEuro = Math.Round((c * 2.53405) / 1.95583, 2);

            if (valutsType.Equals("USD")&&convertValute.Equals("BGN"))
            {
                Console.WriteLine(dolarsToBgrl);

            }
            else if (valutsType.Equals("USD") && convertValute.Equals("EUR"))
            {
                Console.WriteLine(dolarsToEuro);
            }
            else if (valutsType.Equals("USD") && convertValute.Equals("GBP"))
            {
                Console.WriteLine(dolarsToGbp);
            }
            else if (valutsType.Equals("EUR") && convertValute.Equals("BGN"))
            {
                Console.WriteLine(euroToBgrl);
            }
            else if (valutsType.Equals("EUR") && convertValute.Equals("USD"))
            {
                Console.WriteLine(euroToDolars);
            }
            else if (valutsType.Equals("EUR") && convertValute.Equals("GBP"))
            {
                Console.WriteLine(euroToGbp);
            }
            else if (valutsType.Equals("GBP") && convertValute.Equals("BGN"))
            {
                Console.WriteLine(gbpToBgrl);
            }
            else if (valutsType.Equals("GBP") && convertValute.Equals("USD"))
            {
                Console.WriteLine(gbpToDolars);
            }
            else if (valutsType.Equals("GBP") && convertValute.Equals("EUR"))
            {
                Console.WriteLine(gbpToEuro);
            }




        }
    }
}
