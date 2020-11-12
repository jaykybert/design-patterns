using System;
using System.Collections.Generic;

namespace Patterns.Observer
{
    public class ConcreteSubject : ISubject
    {
        private readonly List<IObserver> observers;
        private int importantValue; // This is what the observers are listening for.

        public ConcreteSubject()
        {
            observers = new List<IObserver>();
        }

        public void Register(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            if (observers.Count == 0)
            {
                Console.WriteLine("No observers left!");
            }
            else
            {
                foreach (IObserver observer in observers)
                {
                    observer.Update(importantValue);
                }
            }
        }

        // Update the Subject, and notify observers.
        public void StateChange()
        {
            Random rnd = new Random();
            importantValue = rnd.Next(0, 1000);
            Notify();
        }
    }
}
