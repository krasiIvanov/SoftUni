using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastDigitName
{
    class Number
    {

        public int number;

        public Number(int number)
        {
            this.number = number;
        }

        public string ReturnLastNumberName()
        {
            switch (this.number%10)
            {
                case 1:return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                case 0: return "zero";

                default:
                    return null;
                    
            }
        }

    }
}
