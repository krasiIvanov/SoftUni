using System;

namespace Operation
{
    public class Startup
    {
        private static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string operators = Console.ReadLine();
            int tempNum = 0;
            double tempNUm2 = 0;

            if (operators == "+")
            {
                tempNum = num1 + num2;
                if (tempNum % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", num1, operators, num2, tempNum);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", num1, operators, num2, tempNum);
                }
            }
            else if (operators == "-")
            {
                tempNum = num1 - num2;
                if (tempNum % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", num1, operators, num2, tempNum);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", num1, operators, num2, tempNum);
                }
            }
            else if (operators == "/")
            {
                if (num1 == 0 || num2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", num1);
                }
                else
                {
                    tempNUm2 = (double)num1 / (double)num2;
                    Console.WriteLine("{0} {1} {2} = {3:f2}", num1, operators, num2, tempNUm2);
                }
            }
            else if (operators == "*")
            {
                tempNum = num1 * num2;
                if (tempNum % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", num1, operators, num2, tempNum);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", num1, operators, num2, tempNum);
                }
            }
            else if (operators == "%")
            {
                if (num1 == 0 || num2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", num1);
                }
                else
                {
                    tempNum = num1 % num2;
                    Console.WriteLine("{0} {1} {2} = {3}", num1, operators, num2, tempNum);
                }
            }
        }
    }
}