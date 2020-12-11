using System;

namespace Patterns.Template
{
    /* 
     * The template method pattern defines the skeleton of an algorithm in an operation, deferring some steps to subclasses.
     * Template method lets subclasses redefine certain steps of an algorithm without changing the algorithm structure.
     *
     *
     *  When to use:
     *      * When implementing an algorithm that can have variation, but follows the same set of steps.
     *
     * 
     *  Pros / Cons
     *      + Reduces duplicate code.
     *
     *      
     *  Resources
     *      * https://www.youtube.com/watch?v=7ocpwK9uesw
     *      * https://www.youtube.com/watch?v=aR1B8MlwbRI
     */
    public static class Demo
    {
        public static void ShowDemo()
        {
            Console.WriteLine("Meat Sandwich:");
            Sandwich meatSandwich = new ItalianSandwich();
            meatSandwich.MakeSandwich();

            Console.WriteLine("\nVegetarian Sandwich.");
            Sandwich veggieSandwich = new VegetarianSandwich();
            veggieSandwich.MakeSandwich();
        }
    }
}
