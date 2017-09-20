using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MordorsCrueltyPlan
{
    public class Lembas :Food
    {
        private const int POINT_OF_HAPPINES = 3;

        public Lembas() : base(POINT_OF_HAPPINES)
        {
        }
    }
}
