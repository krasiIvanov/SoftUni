using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MordorsCrueltyPlan
{
   public class Cram :Food
    {
        private const int POINT_OF_HAPPINES = 2;

        public Cram() : base(POINT_OF_HAPPINES)
        {
        }
    }
}
