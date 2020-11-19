using System;

namespace Patterns.Decorator
{
    /* 
     * The decorator pattern attaches additional responsibilites for an object dynamically.
     * Decorators provide a flexible alternative to subclassing for extending functionality.
     */

    /*
     *  When to use:
     *      * When you want the capabilities of inheritance with subclasses, but you need to add functionality at runtime.
     */

    /*
     *  Pros / Cons
     *      + More flexibile than inheritance.
     *      + Simplifies code because you add functionality using many simple classes.
     *      + Rather than rewrite old code you can extend new code.
     * 
     * 
     *  Resources
     *      * https://www.youtube.com/watch?v=GCraGHx6gso
     *      * https://www.youtube.com/watch?v=j40kRwSm4VE&t=593s
     *      * https://stackoverflow.com/questions/25663525/decorator-pattern-and-c-sharp/25664356
     */
    class Demo
    {
        public static void ShowDemo()
        {
            Console.WriteLine("----- First Pizza");
            IPizza dough = new PlainPizza(); // Not decorated.
            IPizza doughAndSauce = new MozzarellaDecorator(dough); // Decorate dough with Mozzarella.
            Console.WriteLine($"\tDesc: {doughAndSauce.Description()}");
            Console.WriteLine($"\tCost: {doughAndSauce.Cost()}");

            // You can also do it like this: (remember Java file readers?)
            Console.WriteLine("----- Second Pizza");
            IPizza cheesePizza = new MozzarellaDecorator(new TomatoSauceDecorator(new PlainPizza()));
            Console.WriteLine($"\tDesc: {cheesePizza.Description()}");
            Console.WriteLine($"\tCost: {cheesePizza.Cost()}");
        }
    }
}
