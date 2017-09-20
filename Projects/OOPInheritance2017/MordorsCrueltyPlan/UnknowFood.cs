using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MordorsCrueltyPlan
{
    public class UnknowFood :Food
    {
        private const int POINT_OF_HAPPINES = -1;

        public UnknowFood() : base(POINT_OF_HAPPINES)
        {
        }
    }
}
