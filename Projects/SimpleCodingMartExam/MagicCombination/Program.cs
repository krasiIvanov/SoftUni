using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicCombination
{
    class Program
    {
        static void Main(string[] args)
        {


            int num = int.Parse(Console.ReadLine());
            

            for (int f1 = 1; f1 <= num; f1++)
            {
                if (f1==10) break;
                
                for (int f2 = 1; f2 <= num; f2++)
                {
                   if(f2 == 10) break;
                    for (int f3 = 1; f3 <= num; f3++)
                    {
                        if (f3== 10) break;
                        for (int f4 = 1; f4 <=num; f4++)
                        {
                            if (f4 == 10) break;
                            for (int f5 = 1; f5 <= num; f5++)
                            {
                                if (f5 == 10) break;
                                for (int f6 = 1; f6 <= num; f6++)
                                {
                                    if (f6 == 10) break;
                                    if (f1*f2*f3*f4*f5*f6==num )
                                    {
                                        
                                        Console.Write("{0}{1}{2}{3}{4}{5} ", f1, f2, f3, f4, f5, f6);
                                    }
                                    
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
