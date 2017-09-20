using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {

            long[] nums = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            while (true)
            {
                string commands = Console.ReadLine();
                if (commands=="end")
                {
                    break;
                }
                string[] commandsArr = commands.Split(' ');
                string operation = commandsArr[0];
                if (commandsArr.Length>1)
                {
                    long index1 = long.Parse(commandsArr[1]);
                    long index2 = long.Parse(commandsArr[2]);
                    switch (operation)
                    {
                        case "swap":
                            Swap(nums, index1, index2);
                            break;
                        case "multiply":
                            Multiply(nums, index1, index2);
                            break;
                        

                        default:
                            break;
                    }
                }
                

                switch (operation)
                {
                    
                    case "decrease":Decrease(nums);
                        break;

                    default:
                        break;
                }
            }
            Console.WriteLine(string.Join(", ",nums));

        }

        private static long[] Decrease(long[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] =nums[i]-1;
            }
            return nums;
        }

        private static long[] Multiply(long[] nums, long index1, long index2)
        {
            nums[index1] *= nums[index2];

            return nums;
        }

        static long[] Swap(long[] nums, long index1 , long index2)
        {
            long temp = nums[index1];
            nums[index1] = nums[index2];
            nums[index2] = temp;

            return nums;
        }
    }
}
