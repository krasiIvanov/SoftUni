using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CypherRoulette
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

            string cypherString = "";
            int changeDirection = 1;
            string lastWord = "";

            for (int i = 0; i < num; i++)
            {

                string word = Console.ReadLine();
                if (word==lastWord)
                {
                    cypherString = "";
                    continue;
                }

                lastWord = word;

                if (word=="spin")
                {
                    changeDirection++;
                    i--;
                }
                else
                {
                    if (changeDirection%2==0)
                    {
                        cypherString = word + cypherString;
                    }
                    else
                    {
                        cypherString += word;
                    }
                    
                }
                
            }

            Console.WriteLine(cypherString);
        }
    }
}
