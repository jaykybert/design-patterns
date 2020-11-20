
using System;

namespace Patterns.Factory
{
    /* 
     * The factory method pattern defines an interface for creating an object, but lets
     * subclasses decide which class to instantiate. Factory method lets the class defer
     * instantiation to subclasses.
     *
     *
     *  When to use:
     *      * When you don't know ahead of time what class object you need.
     *      * When all of the potential classes are in the same class hierarchy.
     *      * To centralise class selection code.
     *      * When you don't want the user to have to know every subclass.
     *      * To encapsulate object creation.
     *
     *
     *  Pros / Cons
     *      + The class is chosen at runtime.
     *      + Separate class decision making from other parts of the program.
     *      + Ability to have multiple factories, each with different creation logic.
     *
     *
     *  Resources
     *      * https://www.youtube.com/watch?v=EcFVTgRHJLM
     *      * https://www.youtube.com/watch?v=ub0DXaeV6hA
     *      * https://stackoverflow.com/questions/25663525/decorator-pattern-and-c-sharp/25664356
     */
    public class Demo
    {
        public static void ShowDemo()
        {
            EnemyFactory enemyFactory = new EnemyFactory();
            Console.WriteLine("Type of Enemy: (S/T/B) ");
            string enemyChoice = Console.ReadLine();
            Enemy enemy = enemyFactory.CreateEnemy(enemyChoice);
            enemy.Move();
            enemy.Attack();
        }
    }
}
