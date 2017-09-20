using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOverflow
{
    class Program
    {
        static void Main(string[] args)
        {

            ulong firstNumber = ulong.Parse(Console.ReadLine());
            ulong secondNumber = ulong.Parse(Console.ReadLine());

            ulong biggerNumber = Math.Max(firstNumber, secondNumber);
            ulong smallerNUmber = Math.Min(firstNumber, secondNumber);

            string smalerType = GetNumberType(smallerNUmber);
            ulong smalerTypeValue = 0;
            switch (smalerType)
            {
                case "byte":smalerTypeValue = byte.MaxValue;
                    break;
                case "ushort": smalerTypeValue = ushort.MaxValue;
                    break;
                case "uint":
                    smalerTypeValue = uint.MaxValue;
                    break;
                case "ulong":
                    smalerTypeValue = ulong.MaxValue;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"bigger type:{GetNumberType(biggerNumber)}");
            Console.WriteLine($"smaller type:{smalerType}");
            Console.WriteLine($"{biggerNumber} can overflow {smalerType} {Math.Round((decimal)biggerNumber / smalerTypeValue)} times");

        }
        public static string GetNumberType(ulong num)
        {
            
            string numberType = "";
            if (byte.MinValue <= num && num <= byte.MaxValue)
            {
                numberType = "byte";
                num=(byte)num;
            }
            else if (ushort.MinValue <= num && num <= ushort.MaxValue)
            {
                numberType = "ushort";
                num = (ushort)num;
            }
            else if (uint.MinValue <= num && num <= uint.MaxValue)
            {
                numberType = "uint";
                num = (uint)num;
            }
            else
            {
                numberType = "ulong";
                
            }
            return numberType;
        }

    }
}
