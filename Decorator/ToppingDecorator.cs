
namespace Patterns.Decorator
{
    /*
     * You can implement the Decorator pattern without the need for the abstract Decorator.
     * Just make the concrete decorators implement IPizza instead, and pass an IPizza into the constructor.
     */
    public abstract class ToppingDecorator : IPizza // Implements the same interface as PlainPizza.
    {
        // Reference the interface, not a concrete class - this allows decorators to be applied to any subclasses of IPizza.
        protected IPizza pizza;

        public ToppingDecorator(IPizza newPizza)
        {
            pizza = newPizza;
        }

        // Methods need to be marked as virtual to be overridden.
        public virtual double Cost()
        {
            return pizza.Cost();
        }

        public virtual string Description()
        {
            return pizza.Description();
        }
    }
}
