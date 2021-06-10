using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachinePart1
{
    class WaterManager : CoffeeMachineManager
    {
        public void AddWater(WaterContainer currentContainer)
        {

            currentContainer.WaterInTank += numberOfCups;
            Console.WriteLine(numberOfCups + " Water added");
        }
        public void UseWater(WaterContainer currentContainer)
        {
            currentContainer.WaterInTank -= numberOfCups;
            Console.WriteLine(numberOfCups + " Water Used");
        }
        
    }
}
