using System;

namespace Patterns.Singleton
{
    /* 
     *  The singleton pattern ensures a class has only one instance and provides a global point of access to it.
     *
     *
     *  When to use:
     *      * When you want to limit class instantiation to one object.
     *
     *
     *  Pros / Cons
     *      + Allows for a single instance that can be managed.
     *      - Being used as a global instance, they hide the dependencies of your application.
     *      - Violates the single responsibility principle - they control their own creation and lifecycle.
     *      - They carry state for the lifetime of the application.
     * 
     * 
     *  Resources
     *      * https://www.youtube.com/watch?v=hUE_j6q0LTQ
     *      * https://www.youtube.com/watch?v=NZaXM67fxbs
     *      * https://www.youtube.com/watch?v=ggqjVuJ0g_8
     *      * https://stackoverflow.com/questions/137975/what-is-so-bad-about-singletons
     */
    public static class Demo
    {
        public static void ShowDemo()
        {
            Console.WriteLine("Cannot create object using: Singleton singleton = new Singleton(); (due to private constructor)");
            Console.WriteLine("Call the static method GetInstance()...");
            Singleton single = Singleton.GetInstance();
            Console.WriteLine("This method returns its instance (or creates it if it hasn't been created already)");
            // Both statements below are referring to the same, single object.
            single.SayHello();
            Singleton.GetInstance().SayHello();
        }
    }
}
