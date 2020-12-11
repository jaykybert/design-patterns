using System;

namespace Patterns.Template
{
    public class VegetarianSandwich : Sandwich
    {
        // Set Hooks
        public override bool WantsMeat { get => false; }
        public override bool WantsCheese { get => false; }
        public override bool WantsVegetables { get => true; }
        public override bool WantsCondiments { get => true; }

        // Override Methods
        public override void AddCheese()
        {
            Console.WriteLine("This won't be called.");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Added the condiments.");
        }

        public override void AddMeat()
        {
            Console.WriteLine("This won't be called.");
        }

        public override void AddVegetables()
        {
            Console.WriteLine("Added the vegetables.");
        }
    }
}
