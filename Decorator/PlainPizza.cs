using System;

namespace Patterns.Decorator
{
    public class PlainPizza : IPizza
    {
        public PlainPizza()
        {
            Console.WriteLine("Adding Dough...");
        }

        public double Cost()
        {
            return 4.00;
        }

        public string Description()
        {
            return "Dough";
        }
    }
}
