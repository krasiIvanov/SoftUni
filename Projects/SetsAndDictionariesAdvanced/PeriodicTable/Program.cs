using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {


            int num = int.Parse(Console.ReadLine());
            SortedSet<string> uniqueElements = new SortedSet<string>();

            for (int i = 0; i < num; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                foreach (var item in tokens)
                {
                    uniqueElements.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ",uniqueElements));
        }
    }
}
