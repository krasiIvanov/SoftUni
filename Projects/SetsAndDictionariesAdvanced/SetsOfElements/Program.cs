using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] tokens = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < tokens[0]; i++)
            {
                int newNUm = int.Parse(Console.ReadLine());
                firstSet.Add(newNUm);
            }
            for (int i = 0; i < tokens[1]; i++)
            {
                int newNUm = int.Parse(Console.ReadLine());
                secondSet.Add(newNUm);
            }
            firstSet.IntersectWith(secondSet);
            foreach (var item in firstSet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
