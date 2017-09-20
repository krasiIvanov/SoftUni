using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersТoWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                LetterNum(currentNum);
            }

        }

        public static void LetterNum(int num)
        {
            
            if (num<-999)
            {
                Console.WriteLine("Too small");
            }
            else if(num>999)
            {
                Console.WriteLine("Too large");
            }
            else
            {
                int absNum = Math.Abs(num);
                if (absNum.ToString().Count()==3)
                {
                    char[] digits = absNum.ToString().ToCharArray();

                    string firstNumber = DigitToWord(digits[0]);
                    string thirdDigit = DigitToWord(digits[2]);
                    if (digits[1] == '0' && digits[2] == '0')
                    {
                        if (num < 0)
                        {
                            Console.WriteLine($"minus {firstNumber}-hundred");
                        }
                        else
                        {
                            Console.WriteLine($"{firstNumber}-hundred");
                        }

                    }
                    else if (digits[1] == '0')
                    {

                        if (num < 0)
                        {
                            Console.WriteLine($"minus {firstNumber}-hundred and {thirdDigit}");
                        }
                        else
                        {
                            Console.WriteLine($"{firstNumber}-hundred and {thirdDigit}");
                        }


                    }
                    else if (digits[1] == '1')
                    {
                        string secondDigit = digits[1].ToString() + digits[2].ToString();
                        string secondnumber = "";
                        switch (secondDigit)
                        {
                            case "10":
                                secondnumber = "ten";
                                break;
                            case "11":
                                secondnumber = "eleven";
                                break;
                            case "12":
                                secondnumber = "twelve";
                                break;
                            case "13":
                                secondnumber = "thirdteen";
                                break;
                            case "14":
                                secondnumber = "fourteen";
                                break;
                            case "15":
                                secondnumber = "fiveteen";
                                break;
                            case "16":
                                secondnumber = "sixteen";
                                break;
                            case "17":
                                secondnumber = "seventeen";
                                break;
                            case "18":
                                secondnumber = "eightteen";
                                break;
                            case "19":
                                secondnumber = "nineteen";
                                break;


                            default:
                                break;
                        }
                        if (num < 0)
                        {
                            Console.WriteLine($"minus {firstNumber}-hundred and {secondnumber}");
                        }
                        else
                        {
                            Console.WriteLine($"{firstNumber}-hundred and {secondnumber}");
                        }

                    }
                    else
                    {
                        char secondDigit = digits[1];
                        string secondDigitString = "";
                        switch (secondDigit)
                        {
                            case '2':
                                secondDigitString = "twenty";
                                break;
                            case '3':
                                secondDigitString = "thirty";
                                break;
                            case '4':
                                secondDigitString = "fourty";
                                break;
                            case '5':
                                secondDigitString = "fifty";
                                break;
                            case '6':
                                secondDigitString = "sixty";
                                break;
                            case '7':
                                secondDigitString = "seventy";
                                break;
                            case '8':
                                secondDigitString = "eighty";
                                break;
                            case '9':
                                secondDigitString = "ninety";
                                break;
                            default:
                                break;
                        }
                        if (num < 0)
                        {
                            Console.WriteLine($"minus {firstNumber}-hundred and {secondDigitString} {thirdDigit}");
                        }
                        else
                        {
                            Console.WriteLine($"{firstNumber}-hundred and {secondDigitString} {thirdDigit}");
                        }

                    }

                }

            }
        }

        public static string DigitToWord(char number)
        {
            string result = "";
            switch (number)
            {
                case '0':
                    result = "";
                    break;
                case '1':result = "one";
                    break;
                case '2':
                    result = "two";
                    break;
                case '3':
                    result = "three";
                    break;
                case '4':
                    result = "four";
                    break;
                case '5':
                    result = "five";
                    break;
                case '6':
                    result = "six";
                    break;
                case '7':
                    result = "seven";
                    break;
                case '8':
                    result = "eight";
                    break;
                case '9':
                    result = "nine";
                    break;
                    
                default:
                    break;
            }
            return result;
        }
    }
}
