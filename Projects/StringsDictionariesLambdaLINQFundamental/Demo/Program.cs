using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            string a = Console.ReadLine();
            string b = Console.ReadLine();

            bool check = false;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i]==b[j])
                    {
                        check = true;
                        break;
                    }
                }
                if (check)
                {
                    break;
                }
            }
            if (check)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
