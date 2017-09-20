using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharRotation
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] symbows = Console.ReadLine().ToCharArray();
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string result = string.Empty;
            int counter = 1;
            for (int i = 0; i < symbows.Length; i++)
            {
                int code = 0;
                if (nums[i]%2==0)
                {
                    code = symbows[i]-nums[i];
                    char newSymbol = (char)code;
                    result += newSymbol;
                }
                else
                {
                    code = symbows[i] + nums[i];
                    char newSymbol = (char)code;
                    result += newSymbol;
                }
                counter++;
            }
            Console.WriteLine(result);

        }
    }
}
