using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastKNumbers
{
    class Program
    {
        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            numbers[0] = 1;
          
            ;
            for (int i = 1; i < n; i++)
            {
                
                for (int j = i-k; j <= i-1; j++)
                {
                    if (j>=0)
                    {
                        numbers[i] += numbers[j];
                    }
                   
                    
                }
               
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]+" ");
            }
        }
    }
}
