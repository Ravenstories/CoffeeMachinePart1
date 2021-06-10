using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachinePart1
{
    public class IngredienceCheck : CoffeeMachineManager
    {
        //Class for checking if alle the paramters for making coffee is met. 
        public void CheckFilter(CoffeeFilter coffeeFilter)
        {
            if (coffeeFilter.IsUsed == true)
            {
                Console.WriteLine("Need new filter...");
                coffeeFilter.IsUsed = false;
                Console.WriteLine("Filter changed.");
            }
        }
        public void CheckWater(WaterContainer currentContainer)
        {

            if (currentContainer.WaterInTank + numberOfCups < currentContainer.MaxWater)
            {
                Console.WriteLine("Going to fill water");
            }
            else
            {
                Console.WriteLine("There can't be that much water");
            }
        }

        public void CheckCoffee(CoffeeFilter currentFilter)
        {

            if (currentFilter.CoffeeIn + numberOfCups < currentFilter.MaxCoffeeIn)
            {
                Console.WriteLine("Going to fill coffee");
            }
            else
            {
                Console.WriteLine("There can't be that much coffee in the machine");
            }
        }
    }
}
