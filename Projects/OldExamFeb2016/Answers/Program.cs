using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answers
{
    class Program
    {
        static void Main(string[] args)
        {


            int numOfQuestions = int.Parse(Console.ReadLine());
            uint[] numbers = new uint[numOfQuestions];
            int countA = 0;
            int countB = 0;
            int countC = 0;
            int countD = 0;
            for (int i = 0; i < numOfQuestions; i++)
            {
                numbers[i] = uint.Parse(Console.ReadLine());
                
            }
            foreach (var item in numbers)
            {
                if (item % 4 == 0)
                {
                    countA++;
                    Console.Write("a ");
                }
                if (item % 4 == 1)
                {
                    countB++;
                    Console.Write("b ");
                }
                if (item % 4 == 2)

                {
                    countC++;
                    Console.Write("c ");
                }
                if (item % 4 == 3)
                {
                    countD++;
                    Console.Write("d ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Answer A: {0}",countA);
            Console.WriteLine("Answer B: {0}", countB);
            Console.WriteLine("Answer C: {0}", countC);
            Console.WriteLine("Answer D: {0}", countD);
        }
    }
}
