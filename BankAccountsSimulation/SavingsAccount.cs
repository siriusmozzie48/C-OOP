using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsApp
{
    public class SavingsAccount:BankAccount
    {
        //public string Owner { get; set; }
        //public Guid AccountNumber { get; set; }
        //public decimal Balance { get; private set; }
        public SavingsAccount(string name, decimal interestRate):base(name + $"({interestRate}%)")
        {
            InterestRate = interestRate;
            
        }
        public decimal InterestRate {  get; set; }

        public override string Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                return $"You cannot deposit {amount}";
            }
            if (amount > 20000)
            {
                return "AML Deposit Limit Reached";
            }
            decimal interestAmount = (InterestRate / 100) * amount;
            Balance += amount + interestAmount;
            return "Deposit completed successfully";

        }
    }
}
