using System;

namespace Patterns.Decorator
{
    public class TomatoSauceDecorator : ToppingDecorator
    {
        public TomatoSauceDecorator(IPizza newPizza) : base(newPizza)
        {
            Console.WriteLine("Adding tomato sauce...");
        }

        public override string Description()
        {
            return $"{base.Description()}, Tomato Sauce";
        }

        public override double Cost()
        {
            return base.Cost() + 0.30;
        }
    }
}
