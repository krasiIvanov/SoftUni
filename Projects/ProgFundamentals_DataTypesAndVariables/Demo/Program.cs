using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal km = 0.00000005m * 9450000000000m;

            decimal speed = 300000;

            decimal seconds = km / speed;
            
            decimal minutes = seconds /60;
            seconds %= 60;
            decimal hours = minutes / 60;
            minutes %= 60;
            decimal days = hours / 24;
            hours %= 24;
            decimal week = days / 7;
            days %= 7;
            Console.WriteLine($"{(int)week}");
            Console.WriteLine($"{(int)days}");
            Console.WriteLine($"{(int)hours}");
            Console.WriteLine($"{(int)minutes}");
            Console.WriteLine($"{(int)seconds}");



        }
    }
}
