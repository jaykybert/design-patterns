using System;

namespace Patterns.Decorator
{
    public class MozzarellaDecorator : ToppingDecorator
    {
        public MozzarellaDecorator(IPizza newPizza) : base(newPizza)
        {
            Console.WriteLine("Adding mozzarella...");
        }

        public override string Description()
        {
            return $"{base.Description()}, Mozzarella";
        }

        public override double Cost()
        {
            return base.Cost() + 0.50;
        }
    }
}
