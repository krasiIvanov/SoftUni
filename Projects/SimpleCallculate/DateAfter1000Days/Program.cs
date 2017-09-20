using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAfter1000Days
{
    class Program
    {
        static void Main(string[] args)
        {

            string date = Console.ReadLine();
            DateTime dt = DateTime.ParseExact(date,"dd-MM-yyyy",null).AddDays(999);

            Console.WriteLine(dt.ToString("dd-MM-yyyy"));
        }
    }
}
