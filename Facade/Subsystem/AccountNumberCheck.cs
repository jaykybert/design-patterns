
namespace Patterns.Facade.Subsystem
{
    public class AccountNumberCheck
    {
        private readonly int accountNumber = 12345678;

        public int GetAccountNumber() { return accountNumber; }

        public bool AccountActive(int accNumToCheck)
        {
            return accNumToCheck == GetAccountNumber();
        }

    }
}
