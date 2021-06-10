using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachinePart1
{
    public class CoffeeMachineManager : Program
    {

        public void StartCoffeeMachine()
        {
            bool done = false;

            WaterContainer currentWaterContainer = new WaterContainer(0, 10);
            CoffeeFilter currentCoffeeFilter = new CoffeeFilter(false, 0, 10);
            IngredienceCheck ingredienceCheck = new IngredienceCheck();
            WaterManager waterManager = new WaterManager();
            CoffeeManager coffeeManager = new CoffeeManager();

            while (!done)
            {
                Console.WriteLine("How many cups of coffee do you want?");
                numberOfCups = Convert.ToInt32(Console.ReadLine());

                if (currentCoffeeFilter.IsUsed == false)
                {
                    ingredienceCheck.CheckFilter(currentCoffeeFilter);
                    ingredienceCheck.CheckWater(currentWaterContainer);
                    ingredienceCheck.CheckCoffee(currentCoffeeFilter);
                    waterManager.AddWater(currentWaterContainer);
                    coffeeManager.AddCoffee(currentCoffeeFilter);
                    waterManager.UseWater(currentWaterContainer);
                    coffeeManager.UseCoffee(currentCoffeeFilter);
                    currentCoffeeFilter.IsUsed = true;
                    Console.WriteLine("DING!");
                    Console.WriteLine(numberOfCups + " Cups made! \n");
                }
            }
            
            
        }

        
    }
}
