using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachinePart2
{
    // Container for the water. (I made it and never looked at it again. I might have done something right)
    public class WaterContainer
    {
        private int waterInTank;
        private int maxWater;
        public int WaterInTank
        {
            get { return waterInTank; }
            set { waterInTank = value; }
        }
        public int MaxWater
        {
            get { return maxWater; }
            set { maxWater = value; }
        }

        public WaterContainer(int waterInTank, int maxWater)
        {
            MaxWater = maxWater;
            WaterInTank = waterInTank;
        }

        

    }
}
