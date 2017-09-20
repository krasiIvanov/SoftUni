using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
   public abstract class Food
    {
        public Food(int quantity)
        {

            this.Quantity = quantity;

        }

        public int Quantity { get; set; }

    }
}
