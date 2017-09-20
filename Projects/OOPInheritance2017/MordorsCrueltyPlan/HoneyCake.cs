using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MordorsCrueltyPlan
{
    public class HoneyCake :Food
    {
        private const int POINT_OF_HAPPINES = 5;

        public HoneyCake() : base(POINT_OF_HAPPINES)
        {
        }
    }
}
