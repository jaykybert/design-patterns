
namespace Patterns.State
{
    /* 
     *  The state design pattern allows an object to alter its behaviour when its internal state changes.
     *  The object will appear to change its class.
     *
     *
     *  When to use:
     *      * When you have a class with many conditionals that alter how the class behaves according to the
     *    current values of the class' fields.
     *    
     *    
     *  Pros / Cons
     *      + Organise the code related to a particular state into its own class (Single Responsibility).
     *      + Introduce new states with changing existing state classes or the context (Open/Closed).
     *      + Eliminate bulky state machine conditionals.
     *      - Can be overkill if a state machine has only a few states or rarely changes.
     *     
     *
     *  Resources
     *      * https://www.youtube.com/watch?v=N12L5D78MAA
     *      * https://www.youtube.com/watch?v=MGEx35FjBuo
     *      * https://refactoring.guru/design-patterns/state
     */
    public static class Demo
    {

        public static void ShowDemo()
        {
            ATMMachine ATM = new ATMMachine();
            ATM.InsertCard();
            ATM.EjectCard();
            ATM.InsertCard();
            ATM.EnterPIN(1234);
            ATM.RequestWithdrawal(1950);
            ATM.InsertCard();
            ATM.EnterPIN(12345);
            ATM.InsertCard();
            ATM.EnterPIN(1234);
            ATM.RequestWithdrawal(100);
        }
    }
}
