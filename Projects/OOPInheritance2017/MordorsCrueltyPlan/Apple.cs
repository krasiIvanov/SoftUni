using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MordorsCrueltyPlan
{
    public class Apple : Food
    {
        private const int POINT_OF_HAPPINES = 1;

        public Apple() : base(POINT_OF_HAPPINES)
        {
        }
    }
}
