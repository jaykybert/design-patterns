
namespace Patterns.Proxy
{
    // The proxy below has a readonly instance of an ATM - it contains no writing/updating functionality.
    public class ATMProxy : IATMData
    {
        /* Another approach could be to use if/else statements to control whether to call a method.
         * This way, the interface could contain all ATM functionality, and the proxy would contain
         * code that determines whether to give access.
         */
        private readonly ATMMachine _ATM; // Underlying object - in here we can control access rights.

        public ATMProxy(string number, double cash)
        {
            _ATM = new ATMMachine(number, cash);
        }

        public string ATMNumber()
        {
            return _ATM.ATMNumber();
        }

        public double TotalATMCash()
        {
            return _ATM.TotalATMCash();
        }
    }
}
