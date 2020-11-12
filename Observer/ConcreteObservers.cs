using System;

namespace Patterns.Observer
{
    public class ConcreteObserverOne : IObserver
    {
        private readonly ISubject subjectReference;

        // Attach the Observer to the Subject's Observer list.
        public ConcreteObserverOne(ISubject subject)
        {
            subjectReference = subject;
            subjectReference.Register(this);
        }

        public void Update(double value)
        {
            Console.WriteLine($"Observer One received an update! New value: {value}");
        }
    }

    public class ConcreteObserverTwo : IObserver
    {
        private readonly ISubject subjectReference;

        public ConcreteObserverTwo(ISubject subject)
        {
            subjectReference = subject;
            subjectReference.Register(this);
        }

        /* We can access the change in data in different ways. It's a matter of preference.
         *      * We can pass it as a parameter to Update() - this way the observer knows exactly what has changed.
         *      * We can access members of the subject through subjectReference.
         */
        public void Update(double value)
        {
            Console.WriteLine($"Observer Two received an update! New value: {value}");
        }
    }

    // ...
}
