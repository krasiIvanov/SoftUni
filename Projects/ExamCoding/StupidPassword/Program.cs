using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidPassword
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int f1 = 1; f1 < n; f1++)
            {
                
                for (int f2 = 1; f2 < n; f2++)
                {
                    
                    for (int f3 = 97; f3 < 97+l; f3++)
                    {
                        
                        char character = (char)f3;
                        string text = character.ToString();

                        for (int f4 = 97; f4< 97 + l; f4++)
                        {
                            
                            char character2 = (char)f4;
                            string text2 = character2.ToString();
                            for (int f5 = 1; f5 < n ; f5++)
                            {
                                if (f5+1>f2 && f5+1>f1)
                                {
                                    Console.Write("{0}{1}{2}{3}{4} ", f1, f2, text, text2, f5 + 1);
                                }
                                
                            }
                        }
                    }
                }
            }



            

        }
    }
}
