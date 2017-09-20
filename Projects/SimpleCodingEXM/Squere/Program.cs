using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squere
{
    class Program
    {
        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            for (int top = -1; top <=n; top++)
            {
                for (int left = -n; left <=n; left++)
                {
                    for (int bot = top+1; bot <= n; bot++)
                    {
                        for (int right = left+1; right <= n; right++)
                        {
                            int width = right-left ;
                            int height = bot - top;

                            int area = width * height;
                            if (area >= m)
                            {
                                Console.WriteLine("({0},{1}) ({2},{3}) ->{4}", left, top, right, bot, area);
                            }
                        }
                    }
                }
            }

        }
    }
}
