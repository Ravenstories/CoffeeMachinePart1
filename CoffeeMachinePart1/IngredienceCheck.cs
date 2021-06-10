using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachinePart2
{
    public class IngredienceCheck : CoffeeMachineManager
    {
        /// Class for checking if alle the paramters for making coffee is met. 
        /// I am unsure if I should split this more up. This is a class for checking ingredients, does it need to be seperate classes? 
        /// Really not happy with this one. 
        public static bool CheckFilter(CoffeeFilter coffeeFilter)
        {
            if (coffeeFilter.IsUsed == true)
            {
                Console.WriteLine("Need new filter...");
                return false;
            }
        
            return true;
        }
        public static bool CheckWater(WaterContainer currentContainer, int amount)
        {

            if (currentContainer.WaterInTank + amount < currentContainer.MaxWater)
            {
                Console.WriteLine("Going to fill water");
                return true;
            }
            else
            {
                Console.WriteLine("There can't be that much water");
                return false;
            }
        }
        public static bool CheckCoffee(CoffeeFilter currentFilter, int amount)
        {

            if (currentFilter.CoffeeIn + amount < currentFilter.MaxCoffeeIn)
            {
                Console.WriteLine("Going to fill coffee");
                return true;

            }
            else
            {
                Console.WriteLine("There can't be that much coffee in the machine");
                return false;

            }
        }
    }

    
}
