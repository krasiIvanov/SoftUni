using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {


            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool flag = false;
            for (int i = 0; i < nums.Length; i++)
            {

                for (int n2 = i+1; n2 < nums.Length; n2++)
                {
                    var sum = nums[i] + nums[n2];
                    //Console.WriteLine("{0}{1} ",nums[i],nums[n2]);
                    //Console.WriteLine(sum);
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (sum == nums[j])
                        {
                            Console.WriteLine("{0} + {1} == {2}", nums[i], nums[n2],nums[j]);
                            flag = true;
                        }
                    }
                }
            }
            if (flag==false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
