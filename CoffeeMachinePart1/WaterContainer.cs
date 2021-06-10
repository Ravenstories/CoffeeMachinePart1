using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachinePart1
{
    public class WaterContainer
    {
        private int waterInTank = 0;
        private int maxWater = 10;
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
