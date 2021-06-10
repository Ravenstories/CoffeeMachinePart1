using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachinePart1
{
    class CoffeeManager : CoffeeMachineManager
    {
        public void AddCoffee(CoffeeFilter currentFilter)
        {

            currentFilter.CoffeeIn += numberOfCups;
            Console.WriteLine(numberOfCups + " Coffee added");
        }

        public void UseCoffee(CoffeeFilter currentFilter)
        {
            currentFilter.CoffeeIn += numberOfCups;
            Console.WriteLine(numberOfCups + " Coffee Used");
        }
    }
}
