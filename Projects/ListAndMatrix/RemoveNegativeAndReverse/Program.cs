using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativeAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List < int > result= new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i]>0)
                {
                    result.Add(numbers[i]);
                }
            }
            result.Reverse();
            if (result.Count>0)
            {
                Console.WriteLine(string.Join(" ",result));
            }
            else
            {
                Console.WriteLine("empty");
            }
            //10 -5 7 9 -33 50
        }
    }
}
