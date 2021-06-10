using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachinePart2
{
    /// My water controller class
    /// It simply adds og subtracks water. The check happens in ingredience check. 
    class WaterController : CoffeeMachineManager
    {
        public static void WaterManage(WaterContainer currentContainer, int amount)
        {
            currentContainer.WaterInTank += amount;
            Console.WriteLine(amount + " Water");
            Console.WriteLine(currentContainer.WaterInTank + " is in the tank");
        }
    }
}
