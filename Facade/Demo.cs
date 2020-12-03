
namespace Patterns.Facade
{
    /* 
     *  The facade pattern provides a unified interface to a set of interfaces in a subsystem. Facade defines
     *  a higher level interface that makes the subsystem easier to use.
     *  
     *  When you create a simplified interface that performs many other actions behind the scenes.
     *  
     *
     *  When to use:
     *      * When you want to minimise complexity for client code.
     *
     * 
     *  Pros / Cons
     *      * Simple to implement.
     *      * Reduces client code complexity.
     *
     *
     *  Resources
     *      * https://www.youtube.com/watch?v=K4FkHVO5iac
     *      * https://www.youtube.com/watch?v=B1Y8fcYrz5o
     */
    public static class Demo
    {
        /* Note: The code inside the subsystem isn't specific to the facade pattern,
         * it just emulates complex interactions that can be abstracted to a higher level.
         */

        public static void ShowDemo()
        {
            // Interact with the facade, which in turn interacts with the subsystem.
            BankAccountFacade accessingBank = new BankAccountFacade(12345678, 1234);
            accessingBank.WithdrawCash(50.00);
            accessingBank.WithdrawCash(900.00);
            accessingBank.DepositCash(200.00);

        }
    }
}
