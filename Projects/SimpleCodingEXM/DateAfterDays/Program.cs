using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAfterDays
{
    class Program
    {
        static void Main(string[] args)
        {


            int days = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            
            string data= days + "-" + month;

            DateTime result = DateTime.Parse(data).AddDays(5);
            //data = result.ToString("d.MM");
            
            Console.WriteLine(result.ToString("d.MM"));


        }
    }
}
