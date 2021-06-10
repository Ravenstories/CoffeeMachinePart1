using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachinePart2
{
    /// My coffee controller class
    /// It simply adds og suptracks coffee, like in the water controller class. The check happens in ingredience check. 
    class CoffeeController : CoffeeMachineManager
    {
        public static void CoffeeManage(CoffeeFilter currentFilter, int amount)
        {
            currentFilter.CoffeeIn += amount;
            Console.WriteLine(amount + " Coffee");
            Console.WriteLine(currentFilter.CoffeeIn + " is in the filter");
        }
    }
}
