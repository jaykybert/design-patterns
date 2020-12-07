using System;

namespace Patterns.Proxy
{
    /* 
     *  The proxy pattern acts as a wrapper around an object that the client interacts with.
     *  It's an object that contains access management logic which controls access to the other class.
     *  
     *  Three types of proxies:
     *      * Remote - When you want to access a resource remotely (on a server, in a different project, etc.).
     *      * Virtual - Controls access to a resource that is expensive to create.
     *      * Protection - Controls access to a resource based on access rights.
     *  
     *
     *  When to use:
     *      * Security reasons - protection proxy (access rights).
     *      * Object is expensive to create - virtual proxy (lazy evaluation).
     *      * Need to access remote resource - remote proxy.
     *      
     *
     *  Pros / Cons
     *      * Simple to implement.
     *      * Provides access management.
     *
     *
     *  Resources
     *      * https://www.youtube.com/watch?v=NwaabHqPHeM
     *      * https://www.youtube.com/watch?v=cHg5bWW4nUI
     */
    public static class Demo
    {
        public static void ShowDemo()
        {
            IATMData proxyATM = new ATMProxy("12345", 100.00);
            Console.WriteLine($"ATM Number: {proxyATM.ATMNumber()}");
            Console.WriteLine($"ATM Cash: {proxyATM.TotalATMCash()}");

            // Even a real ATMMachine object can't call it's other methods (since IATMData is used in type declaration).
            IATMData realATM = new ATMMachine("123456", 2000.00);
        }
    }
}
