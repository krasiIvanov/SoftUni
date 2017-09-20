using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MordorsCrueltyPlan
{
   public abstract class Food
    {

        public Food(int pointsOfHappines)
        {
            this.PointsofHappines = pointsOfHappines;
        }

        public int PointsofHappines { get;private set; }

    }
}
