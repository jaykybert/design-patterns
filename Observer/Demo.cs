using System;
using System.Threading;

namespace Patterns.Observer
{
    /* 
     * The Observer pattern is a software design pattern in which an object, called the subject, maintains a list
     * of its dependents, called observers, and notifies them automatically of any state changes, usually by
     * calling one of their methods.
     *
     *
     *  When to use:
     *      * When you need many other objects to receive an update when another object changes. 
     *
     *
     *  Pros / Cons
     *      + Loose coupling is a benefit.
     *      + The subject (publisher) doesn't need to know anything about the observers (subscribers).
     *      - The subject may send updates that aren't needed by the observer.
     *      
     *      
     *  Resources
     *      * https://www.youtube.com/watch?v=_BpmfnqjgzQ&t=2537s
     *      * https://www.youtube.com/watch?v=wiQdrH2YpT4    
     */


    public static class Demo
    {
        public static void ShowDemo()
        {
            // Create a subject, attach some observers.
            ConcreteSubject subject = new ConcreteSubject();

            // The observers contain a reference to the subject, and attach themselves to the observer list through it. No need to attach them here.
            ConcreteObserverOne obsOne = new ConcreteObserverOne(subject);
            ConcreteObserverTwo obsTwo = new ConcreteObserverTwo(subject);

            for(int i=0; i < 3; i++)
            {
                subject.StateChange(); // Simulate a change in an important value that observers must be made aware of.
                Thread.Sleep(1000);
            }

            Console.WriteLine("Unregistering Observer One...");
            subject.Unregister(obsOne);

            for(int i=0; i < 3; i++)
            {
                subject.StateChange();
                Thread.Sleep(1000);
            }

            Console.WriteLine("Unregistering Observer Two...");
            subject.Unregister(obsTwo);

            subject.StateChange();
        }
    }
}
