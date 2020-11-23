using System;
using Patterns.Abstract_Factory.Factories;

namespace Patterns.Abstract_Factory
{
    /* 
     *  The abstract factory pattern provides an interface for creating families of related or dependent objects,
     *  without specifying their concrete classes.
     * 
     *  It is like a factory, but everything is encapsulated:
     *      * The method that orders the object.
     *      * The factories that build the object.
     *      * The final objects (the final objects contain objects that use the strategy pattern).
     *
     *
     *  When to use:
     *      * When you have many objects that can be added, or changed dynamically during runtime.
     *
     *
     *  Pros / Cons
     *      + Allows you to create families of related objects without specifying a concrete class.
     *      + You can model anything you can imagine and have those objects interact through common interfaces.
     *      - Complex.
     * 
     * 
     *  Resources
     *      * https://www.youtube.com/watch?v=v-GiuMmsXj4
     *      * https://www.youtube.com/watch?v=xbjAsdAK4xQ
     *      * https://www.youtube.com/watch?v=DeptnGzMl40
     */
    public static class Demo
    {
        public static void ShowDemo()
        {
            Client smartwear = new Client(new SmartClothesFactory());
            Console.WriteLine(smartwear.DescribeOutfit());

            Client casualwear = new Client(new CasualClothesFactory());
            Console.WriteLine(casualwear.DescribeOutfit());
        }
    }
}
