using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSumAfterExtraction
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> firstNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < firstNumbers.Count; i++)
            {
                if (secondNumbers.Contains(firstNumbers[i]))
                {
                    secondNumbers.Remove(firstNumbers[i]);
                }
            }
            if (firstNumbers.Sum()==secondNumbers.Sum())
            {
                Console.WriteLine($"Yes. Sum: {firstNumbers.Sum()}");
            }
            else
            {
                int diff = Math.Abs(firstNumbers.Sum() - secondNumbers.Sum());
                Console.WriteLine($"No. Diff: {diff}");
            }

        }
    }
}
