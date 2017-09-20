using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    class Number
    {

        public int number;
        public bool isPrime;

        public Number(int number, bool isPrime)
        {
            this.number = number;
            this.isPrime = isPrime;
        }

        public int GetNextPrime()
        {
            int nextNumber = this.number + 1;
            while (true)
            {
                bool isPrime = true;
                if (this.number==0 || this.number==1)
                {
                    return this.number + 1;
                }
                else
                {
                    for (int i = 2; i < Math.Sqrt(nextNumber); i++)
                    {
                        if (nextNumber%i==0)
                        {
                            isPrime = false;
                            break;
                        }

                    }
                    if (isPrime)
                    {
                        return nextNumber;
                    }
                }
                nextNumber++;
            }
        }

       
    }
}
