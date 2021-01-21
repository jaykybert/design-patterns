using Patterns.State.States;

namespace Patterns.State
{
    class ATMMachine
    {
        private IATMState ATMState;

        public ATMMachine()
        {
            Cash = 2000;
            PINCorrect = false;

            HasCardState = new HasCard(this);
            NoCardState = new NoCard(this);
            CorrectPINState = new CorrectPIN(this);
            NoMoneyState = new NoMoney(this);

            ATMState = NoCardState;
        }

        public void SetATMState(IATMState newState)
        {
            ATMState = newState;
        }

        public void InsertCard()
        {
            ATMState.InsertCard();
        }

        public void EjectCard()
        {
            ATMState.EjectCard();
        }

        public void RequestWithdrawal(int cash)
        {
            ATMState.RequestWithdrawal(cash);
        }

        public void EnterPIN(int PIN)
        {
            ATMState.EnterPIN(PIN);
        }

        public int Cash { get; set; }
        public bool PINCorrect { get; set; }

        // State Properties
        public IATMState HasCardState { get; private set; }
        public IATMState NoCardState { get; private set; }
        public IATMState CorrectPINState { get; private set; }
        public IATMState NoMoneyState { get; private set; }
    }
}
