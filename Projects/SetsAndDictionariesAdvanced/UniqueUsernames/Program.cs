using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {


            int num = int.Parse(Console.ReadLine());

            HashSet<string> uniqueNames = new HashSet<string>();

            for (int i = 0; i < num; i++)
            {
                string names = Console.ReadLine();
                uniqueNames.Add(names);
            }
            foreach (var item in uniqueNames)
            {
                Console.WriteLine(item);
            }

        }
    }
}
