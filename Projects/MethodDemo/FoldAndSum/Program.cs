using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {

            var arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] arr2 = new int[arr1.Length / 2];
            int[] tempArr1 = new int[arr2.Length / 2];
            int[] tempArr2 = new int[arr2.Length / 2];

            int end = arr1.Length / 4;
            int end2 = end + 2 * end;
            for (int i = 0; i < tempArr1.Length; i++)
            {

                tempArr1[i] = arr1[end - i - 1];
            }
            for (int i = 0; i < tempArr2.Length; i++)
            {
                tempArr2[i] = arr1[arr1.Length - i - 1];

            }

            arr2 = tempArr1.Union(tempArr2).ToArray();

            int[] arr3 = new int[arr1.Length / 2];
            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i] = arr1[end + i];
            }
            int[] finalArr = new int[arr2.Length];
            for (int i = 0; i < finalArr.Length; i++)
            {
                finalArr[i] = arr2[i] + arr3[i];
            }
            Console.WriteLine(string.Join(" ",finalArr));
        }
                 
        
    }
}
