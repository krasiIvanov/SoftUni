using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MordorsCrueltyPlan
{
   public class MoodFactory
    {
        private const int ANGRY_TOP_VALUE = -5;
        private const int SAD_TOP_VALUE = 0;
        private const int HAPPY_TOP_VALUE = 15;

        public static Mood GetMood(int pointOfHappines)
        {
            if (pointOfHappines<ANGRY_TOP_VALUE)
            {
                return new Angry(pointOfHappines);
            }
            else if (pointOfHappines<=SAD_TOP_VALUE)
            {
                return new Sad(pointOfHappines);
            }
            else if (pointOfHappines<=HAPPY_TOP_VALUE)
            {
                return new Happy(pointOfHappines);
            }
            else
            {
                return new JavaScript(pointOfHappines);
            }
        }

    }
}
