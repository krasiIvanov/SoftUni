using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Numbers
{
    class Program
    {
        static void Main(string[] args)
        {


            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            //a ≤ n1 < n2 < n3 < n4 ≤ b

            if (b - a < 3)
                Console.WriteLine("No");

            

            for (int first = a; first <= b-3; first++)
            {
                for (int seconf = first+1; seconf <= b-2; seconf++)
                {
                    for (int third = seconf+1; third <= b-1; third++)
                    {
                        for (int fourth = third+1; fourth <= b; fourth++)
                        {
                            Console.WriteLine("{0} {1} {2} {3}",first,seconf,third,fourth);
                        }
                    }
                }
            }
        }
    }
}
