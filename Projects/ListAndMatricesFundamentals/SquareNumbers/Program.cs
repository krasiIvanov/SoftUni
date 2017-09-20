using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        
            List<int> result = new List<int>();
            

            for (int i = 0; i < nums.Count; i++)
            {
                var temp = Math.Sqrt(nums[i]);
                if (nums[i]%temp==0)
                {
                    result.Add(nums[i]);
                }
            }
            result.Sort((a,b)=>b.CompareTo(a));
            
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
