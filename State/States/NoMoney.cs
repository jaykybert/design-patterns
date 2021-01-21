using System;

namespace Patterns.State.States
{
    class NoMoney : IATMState
    {
        private ATMMachine _ATMMachine;

        public NoMoney(ATMMachine ATM)
        {
            _ATMMachine = ATM;
        }

        public void InsertCard()
        {
            Console.WriteLine("No cash in ATM.");
        }

        public void EjectCard()
        {
            Console.WriteLine("No cash in ATM.");
        }

        public void EnterPIN(int PIN)
        {
            Console.WriteLine("No cash in ATM.");
        }

        public void RequestWithdrawal(int cash)
        {
            Console.WriteLine("No cash in ATM.");
        }
    }
}
