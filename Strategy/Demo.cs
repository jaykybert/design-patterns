using System;

namespace Development.Strategy
{
    /* 
     * The strategy pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable.
     * Strategy lets the algorithm vary independently from clients that use it.
     */


    /*
     *  When to use:
     *      * When you want to define a class that will have one behaviour that is similar to other behaviours (flying, not flying, etc.).
     *      * When you need to use one of several behaviors dynamically.
     */

    /*
     *  Pros / Cons
     *      + Often reduces long lists of conditionals.
     *      + Avoids duplicate code.
     *      + Keeps class changes from forcing other class changes
     *      + Can hide complicated/secret code from the user.
     *      - Increased number of classes/interfaces.
     * 
     */

    class Demo
    {
         public static void ShowDemo()
        {
            // You could also hard-code the behaviours in the respective constructors (if they won't change). I.E. Dog() { FlyingBehaviour = ... }

            Dog dog = new Dog("Charlie", new NoFlyStrategy());
            Bird bird = new Bird("Tweety", new FlyStrategy());

            Console.WriteLine($"Dog:\t{dog.Fly()}");
            Console.WriteLine($"Bird:\t{bird.Fly()}");

            // Update the Flying behaviour at runtime.
            dog.FlyingBehaviour = new FlyStrategy();
            Console.WriteLine("Giving the dog wings...");
            Console.WriteLine($"Dog:\t{dog.Fly()}");
        }
    }
}
