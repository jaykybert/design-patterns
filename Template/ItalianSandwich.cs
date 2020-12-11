using System;

namespace Patterns.Template
{
    public class ItalianSandwich : Sandwich
    {
        // Set Hooks
        public override bool WantsMeat { get => true; }
        public override bool WantsCheese { get => true; }
        public override bool WantsVegetables { get => true; }
        public override bool WantsCondiments { get => true; }

        // Override Methods
        public override void AddCheese()
        {
            Console.WriteLine("Added the cheese.");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Added the condiments.");
        }

        public override void AddMeat()
        {
            Console.WriteLine("Added the meat.");
        }

        public override void AddVegetables()
        {
            Console.WriteLine("Added the vegetables.");
        }
    }
}
