using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MordorsCrueltyPlan
{
   public abstract class Mood
    {
        private int pointsOfHappines;

        public Mood(int pointsOfHappines)
        {

            this.pointsOfHappines = pointsOfHappines;

        }

    }
}
