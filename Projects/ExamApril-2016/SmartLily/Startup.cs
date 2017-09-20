using System;

namespace SmartLily
{
    public class Startup
    {
        private static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washmachPrice = double.Parse(Console.ReadLine());
            int toysPrice = int.Parse(Console.ReadLine());

            int evenCount = 0;
            int evenSum = 0;
            int evenGift = 0;

            for (int i = 2; i <= age; i += 2)
            {
                evenCount++;
                evenGift += 10;
                evenSum += evenGift;
            }

            int oddCount = age - evenCount;
            int oddSum = oddCount * toysPrice;

            int totalSum = evenSum + oddSum - evenCount;

            if (totalSum >= washmachPrice)
            {
                Console.WriteLine("Yes! {0:0.00}", (double)(totalSum - washmachPrice));
            }
            else
            {
                Console.WriteLine("No! {0:0.00}", (double)(washmachPrice - totalSum));
            }
        }
    }
}