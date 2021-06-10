using System;

namespace CoffeeMachinePart1
{
    public class Program
    {
        public static int numberOfCups;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            

            CoffeeMachineManager coffeeMachine = new CoffeeMachineManager();
            coffeeMachine.StartCoffeeMachine();

            Console.ReadKey();
        }
    }
}
