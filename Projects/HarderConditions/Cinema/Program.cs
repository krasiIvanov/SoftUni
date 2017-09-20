using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {

            string tickets = Console.ReadLine();
            double row = double.Parse(Console.ReadLine());
            double col = double.Parse(Console.ReadLine());

            double price =0;
            if (tickets.Equals("Premiere")) price = 12.0;
            else if (tickets.Equals("Normal")) price = 7.5;
            else if (tickets.Equals("Discount")) price = 5;

            Console.WriteLine("{0:f2} leva",(row*col)*price);


        }
    }
}
