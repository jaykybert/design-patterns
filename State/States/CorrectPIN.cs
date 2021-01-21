using System;

namespace Patterns.State.States
{
    class CorrectPIN : IATMState
    {
        private ATMMachine _ATMMachine;

        public CorrectPIN(ATMMachine ATM)
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
            Console.WriteLine("PIN already entered.");
        }

        public void RequestWithdrawal(int cash)
        {
            if(cash > _ATMMachine.Cash)
            {
                Console.WriteLine("Not enough cash in machine. Card Ejected.");
                _ATMMachine.SetATMState(_ATMMachine.NoCardState);
            }
            else
            {
                Console.WriteLine($"Withdrew £{cash}.");
                _ATMMachine.Cash = _ATMMachine.Cash - cash;
                Console.WriteLine("Card Ejected.");
                _ATMMachine.SetATMState(_ATMMachine.NoCardState);

                if(_ATMMachine.Cash == 0)
                {
                    _ATMMachine.SetATMState(_ATMMachine.NoMoneyState);
                }
            }
        }
    }
}
