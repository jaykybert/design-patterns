using System;

namespace Patterns.Template
{
    public abstract class Sandwich
    {
        // Algorithm Template
        public void MakeSandwich()
        {
            CutBread();

            if (WantsMeat)
            {
                AddMeat();
            }

            if (WantsCheese)
            {
                AddCheese();
            }

            if (WantsVegetables)
            {
                AddVegetables();
            }

            if (WantsCondiments)
            {
                AddCondiments();
            }

            WrapSandwich();
        }

        // Abstract methods to force subclasses to override.
        public abstract void AddMeat();
        public abstract void AddCheese();
        public abstract void AddVegetables();
        public abstract void AddCondiments();

        // Naturally sealed. Cannot be overridden.
        public void CutBread()
        {
            Console.WriteLine("Cut the bread.");
        }

        public void WrapSandwich() {
            Console.WriteLine("Wrapped the sandwich.");
        }

        // Hooks
        public abstract bool WantsMeat { get; }
        public abstract bool WantsCheese { get; }
        public abstract bool WantsVegetables { get; }
        public abstract bool WantsCondiments { get; }
    }
}
