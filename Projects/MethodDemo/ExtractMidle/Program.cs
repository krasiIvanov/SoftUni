using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractMidle
{
    class Program
    {
        static void Main(string[] args)
        {



            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

           

        private static int[] MidleArr(int[] arr)
        {
            int start = arr.Length / 2 - 1;
            int end = start + 2;

            if (arr.Length == 1)
            {
                start = end = 0;
            }
            else if (arr.Length % 2 == 0)
            {
                end--;
            }
            int[] tempArr = new int[end-start+1];

            for (int i = start; i < end; i++)
            {
                int count = 0;

                tempArr[i] = arr[i];
                count++;
            }
            return tempArr;
        }
    }
}
