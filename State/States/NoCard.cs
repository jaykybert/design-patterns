using System;

namespace Patterns.State.States
{
    class NoCard : IATMState
    {
        private ATMMachine _ATMMachine;

        public NoCard(ATMMachine ATM)
        {
            _ATMMachine = ATM;
        }

        public void InsertCard()
        {
            Console.WriteLine("Card Entered. Please Enter PIN.");
            _ATMMachine.SetATMState(_ATMMachine.HasCardState);
        }

        public void EjectCard()
        {
            Console.WriteLine("Enter Card.");
        }

        public void EnterPIN(int PIN)
        {
            Console.WriteLine("Enter Card.");
        }

        public void RequestWithdrawal(int cash)
        {
            Console.WriteLine("Enter Card.");
        }
    }
}
