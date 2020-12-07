
namespace Patterns.Proxy
{
    public class ATMMachine : IATMData
    {
        private readonly string _ATMNumber;
        private double _cash;

        public ATMMachine(string number, double cash)
        {
            _ATMNumber = number;
            _cash = cash;
        }

        public string ATMNumber()
        {
            return _ATMNumber; ;
        }

        public double TotalATMCash()
        {
            return _cash;
        }


        // Other Methods that aren't in the interface.
        public double WithdrawCash(double amount)
        {
            if(_cash - amount >= 0)
            {
                _cash -= amount;
                return amount;
            }
            else
            {
                return 0.00;
            }
        }
    }
}
