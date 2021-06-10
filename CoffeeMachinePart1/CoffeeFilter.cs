using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachinePart2
{
    // Container for the coffee. (I made it and never looked at it again. I might have done something right)
    public class CoffeeFilter
    {
        private bool isUsed;
        private int coffeeIn;
        private int maxCoffeeIn;

        public bool IsUsed
        {
            get { return isUsed; }
            set { isUsed = value; }
        }
        public int CoffeeIn
        {
            get { return coffeeIn; }
            set { coffeeIn = value; }
        }
        public int MaxCoffeeIn
        {
            get { return maxCoffeeIn; }
            set { maxCoffeeIn = value; }
        }

        public CoffeeFilter(bool isUsed, int coffeeIn, int maxCoffeeIn)
        {
            IsUsed = isUsed;
            CoffeeIn = coffeeIn;
            MaxCoffeeIn = maxCoffeeIn;
        }
    }
}
