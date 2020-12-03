using System;

namespace Patterns.Facade.Subsystem
{
    public class FundsCheck
    {
        private double cashInAccount = 1000.00;

        public double GetCashInAccount() { return cashInAccount; }

        public void DecreaseCashInAccount(double cashWithdrawn)
        {
            cashInAccount -= cashWithdrawn;
        }

        public void IncreaseCashInAccount(double cashDeposited)
        {
            cashInAccount += cashDeposited;
        }

        /* This method shouldn't also carry out the transaction in real code.
         * Functions should have a single responsibility.
         */
        public bool HaveEnoughMoney(double cashToWithdraw)
        {
            if(cashToWithdraw > GetCashInAccount())
            {
                Console.WriteLine("Error: You don't have enough money.");
                Console.WriteLine($"Current Balance: {GetCashInAccount()}");
                return false;
            }
            else
            {
                DecreaseCashInAccount(cashToWithdraw);
                Console.WriteLine("Withdraw Complete.");
                Console.WriteLine($"New Balance: {GetCashInAccount()}");
                return true;
            }
        }

        public void MakeDeposit(double cashToDeposit)
        {
            IncreaseCashInAccount(cashToDeposit);
            Console.WriteLine("Deposit Complete.");
            Console.WriteLine($"New Balance: {GetCashInAccount()}");
        }
    }
}
