using System;

namespace Patterns.State.States
{
    class HasCard : IATMState
    {
        private ATMMachine _ATMMachine;

        public HasCard(ATMMachine ATM)
        {
            _ATMMachine = ATM;
        }

        public void InsertCard()
        {
            Console.WriteLine("Card already entered.");
        }

        public void EjectCard()
        {
            Console.WriteLine("Card Ejected.");
            _ATMMachine.SetATMState(_ATMMachine.NoCardState);
        }

        public void EnterPIN(int PIN)
        {
            if(PIN == 1234)
            {
                Console.WriteLine("PIN Correct.");
                _ATMMachine.PINCorrect = true;
                _ATMMachine.SetATMState(_ATMMachine.CorrectPINState);
            }
            else
            {
                Console.WriteLine("PIN Incorrect.");
                _ATMMachine.PINCorrect = false;
                Console.WriteLine("Card Ejected.");
                _ATMMachine.SetATMState(_ATMMachine.NoCardState);
            }
        }

        public void RequestWithdrawal(int cash)
        {
            Console.WriteLine("Please Enter PIN.");
        }
    }
}
