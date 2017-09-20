using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            while (arr.Length>1)
            {
               
                int[] condenset = new int[arr.Length - 1];
                for (int i = 0; i < arr.Length-1; i++)
                {
                    condenset[i] = arr[i] + arr[i + 1];
                    

                }
                arr = condenset;
                
                
                
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
