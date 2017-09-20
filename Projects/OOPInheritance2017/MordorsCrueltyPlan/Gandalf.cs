using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MordorsCrueltyPlan
{
    class Gandalf
    {
        private const int DEFAULT_HAPPINESS_POINT = 0;

        private int pointsOfHappines;
        private Mood mood;


        public Gandalf()
        {

            this.pointsOfHappines = DEFAULT_HAPPINESS_POINT;
            this.SetMood();
           
        }

        public void Eat(List<Food> foods)
        {
            foreach (var food in foods)
            {
                pointsOfHappines += food.PointsofHappines;
            }
            SetMood();
        }

        public void SetMood()
        {
            mood = MoodFactory.GetMood(pointsOfHappines);
        }

        public override string ToString()
        {
            return $"{pointsOfHappines}\n\r{mood.GetType().Name}";
        }


    }
}
