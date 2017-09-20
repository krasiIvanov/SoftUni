using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {

            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            int result = (hour*60) + (min+15);

            TimeSpan resultHour = TimeSpan.FromMinutes(result);
            

            Console.WriteLine(resultHour.ToString(@"h\:mm"));

        }
    }
}
