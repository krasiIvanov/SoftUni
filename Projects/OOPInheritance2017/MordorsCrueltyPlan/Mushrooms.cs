using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MordorsCrueltyPlan
{
   public class Mushrooms :Food
    {
        private const int POINT_OF_HAPPINES = -10;

        public Mushrooms() : base(POINT_OF_HAPPINES)
        {
        }
    }
}
