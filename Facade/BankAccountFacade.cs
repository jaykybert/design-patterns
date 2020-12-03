using System;
using Patterns.Facade.Subsystem;

namespace Patterns.Facade
{
    public class BankAccountFacade
    {
        private readonly int accountNumber;
        private readonly int securityCode;

        AccountNumberCheck accountChecker;
        SecurityCodeCheck securityCodeChecker;
        FundsCheck fundsChecker;

        public BankAccountFacade(int newAcctNum, int newSecCode)
        {
            // Objects and values that are used in the subsystem.
            accountNumber = newAcctNum;
            securityCode = newSecCode;

            accountChecker = new AccountNumberCheck();
            securityCodeChecker = new SecurityCodeCheck();
            fundsChecker = new FundsCheck();
        }

        public int GetAccountNumber() { return accountNumber; }
        public int GetSecurityCode() { return securityCode; }

        public void WithdrawCash(double cashToWithdraw)
        {
            if(accountChecker.AccountActive(GetAccountNumber())
                && securityCodeChecker.IsSecurityCodeCorrect(GetSecurityCode())
                && fundsChecker.HaveEnoughMoney(cashToWithdraw))
            {
                Console.WriteLine("Transaction Complete.");
            }
            else
            {
                Console.WriteLine("Transaction Failed.");
            }
            Console.WriteLine("\n");
        }

        public void DepositCash(double cashToDeposit)
        {
            if (accountChecker.AccountActive(GetAccountNumber())
                && securityCodeChecker.IsSecurityCodeCorrect(GetSecurityCode()))
            {
                fundsChecker.MakeDeposit(cashToDeposit);
                Console.WriteLine("Transaction Complete.");
            }
            else
            {
                Console.WriteLine("Transaction Failed.");
            }
            Console.WriteLine("\n");
        }
    }
}
