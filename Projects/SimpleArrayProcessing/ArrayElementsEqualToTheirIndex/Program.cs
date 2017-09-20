using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayElementsEqualToTheirIndex
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            List<int> result = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (i == input[i])
                {
                    result.Add(i);
                }
            }

            Console.WriteLine(String.Join(" ", result));
            
        }
    }
}
