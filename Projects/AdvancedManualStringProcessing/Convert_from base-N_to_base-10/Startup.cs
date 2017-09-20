using System;

namespace Convert_from_base_N_to_base_10
{
    public class Startup
    {
        private static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int baseNum = int.Parse(input[0]);
            string num = input[1];
            double base10Num = 0;
            int count = 1;
            for (int i = 0; i < num.Length; i++)
            {
                int tempNum = int.Parse(num[i].ToString());
                base10Num += tempNum * Math.Pow(baseNum, num.Length - count);
                count++;
            }
            Console.WriteLine(base10Num);
        }
    }
}