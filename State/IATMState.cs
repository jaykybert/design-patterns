
namespace Patterns.State
{
    interface IATMState
    {
        void InsertCard();
        void EjectCard();
        void EnterPIN(int PIN);
        void RequestWithdrawal(int cash);
    }
}
