using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    class Program
    {
        static void Main(string[] args)
        {

            uint newcomers = uint.Parse(Console.ReadLine());
            int gryffindor = 0;
            int slytherin = 0;
            int ravenclaw = 0;
            int hufflepuff = 0;
            for (int i = 0; i < newcomers; i++)
            {
                int sum = 0;
                string[] names = Console.ReadLine().Split(' ')  ;
                string firstName = names[0];
                string lastName = names[1];


                for (int j = 0; j < firstName.Length; j++)
                {
                    sum += firstName[j];
                }
                for (int n = 0; n < lastName.Length; n++)
                {
                    sum += lastName[n];
                }
                if (sum%4==0)
                {
                    gryffindor++;
                    Console.WriteLine("Gryffindor {0}{1}{2}",sum,firstName[0],lastName[0]);
                }
                else if (sum%4==1)
                {
                    slytherin++;
                    Console.WriteLine("Slytherin {0}{1}{2}", sum, firstName[0], lastName[0]);
                }
                else if (sum%4==2)
                {
                    ravenclaw++;
                    Console.WriteLine("Ravenclaw {0}{1}{2}", sum, firstName[0], lastName[0]);

                }
                else if (sum%4==3)
                {
                    hufflepuff++;
                    Console.WriteLine("Hufflepuff {0}{1}{2}", sum, firstName[0], lastName[0]);
                }
               
                        
             }
            Console.WriteLine();
            Console.WriteLine("Gryffindor: {0}",gryffindor);
            Console.WriteLine("Slytherin: {0}", slytherin);
            Console.WriteLine("Ravenclaw: {0}", ravenclaw);
            Console.WriteLine("Hufflepuff: {0}", hufflepuff);



        }
    }
}
