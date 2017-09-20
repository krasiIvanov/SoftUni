using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            
            //2 2 2 2 3 7 8 8
            int[] arr = new int[numbers.Count+1];

            for (int i = 0; i < numbers.Count; i++)
            {
                arr[numbers[i]]++;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>0)
                {
                    Console.WriteLine("{0} -> {1}", i, arr[i]);
                }
                
            }
        }
    }
}
