using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachinePart2
{
    public class CoffeeMachineManager
    {
        /// My manager class, I have tried to keep it so that it runs the program so if there is need of change it will happen here. 
        /// But I am in a bit of distress.. I can see a conflict in the "Single Responsibility" and the "Open Closed" Principle. 
        /// I haven't created a system you can extend without conflicting in the Open Closed principle, but if I change it, it wont adhere to Single Responsibilty.. I need some experience and guidence. 
        
        public static void StartCoffeeMachine()
        {
            bool done = false;

            WaterContainer currentWaterContainer = new WaterContainer(0, 10);
            CoffeeFilter currentCoffeeFilter = new CoffeeFilter(false, 0, 10);

            while (!done)
            {
                Console.WriteLine("How many cups of coffee do you want?");
                int numberOfCups = Convert.ToInt32(Console.ReadLine());

                //Brewing the coffee by running through all the steps. 
                //I can see an issue with this check getting very long if more checks are needed in the future. 
                //I want to make Ingredience to an interface. 
                if (IngredienceCheck.CheckFilter(currentCoffeeFilter) && IngredienceCheck.CheckWater(currentWaterContainer, numberOfCups) && IngredienceCheck.CheckCoffee(currentCoffeeFilter, numberOfCups))
                {
                    WaterController.WaterManage(currentWaterContainer, numberOfCups);
                    CoffeeController.CoffeeManage(currentCoffeeFilter, numberOfCups);
                    WaterController.WaterManage(currentWaterContainer, -numberOfCups);
                    CoffeeController.CoffeeManage(currentCoffeeFilter, -numberOfCups);
                    currentCoffeeFilter.IsUsed = true;
                    Console.WriteLine("DING!");
                    Console.WriteLine(numberOfCups + " Cups made! \n");
                }
                else if (!IngredienceCheck.CheckFilter(currentCoffeeFilter))
                {
                    currentCoffeeFilter.IsUsed = false;
                    Console.WriteLine("Filter changed, try again \n");
                }
            }
        }
    }
}
