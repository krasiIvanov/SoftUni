using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
   public class Tier
    {
        public double tierPressure;
        public int tierAge;

        public Tier(double tierPressure,int tierAge)
        {
            this.tierPressure = tierPressure;
            this.tierAge = tierAge;
        }
    }
}
