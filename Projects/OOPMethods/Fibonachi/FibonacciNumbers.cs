using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi
{
    class FibonacciNumbers
    {

       public List<long> numbers;

        public FibonacciNumbers()
        {
            this.numbers = new List<long>();
        }

        public List<long> GetFibNumbersInRange(int startPosition,int endPosition)
        {
            return this.numbers.Skip(startPosition).Take(endPosition - startPosition).ToList();
        }
    }
}
