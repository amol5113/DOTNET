using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankLibrary;
namespace BankLibrary
{
 public    class SavingAccount : Account
    {
        decimal _balance;

        public SavingAccount(int accountNumber, string holderName, 
            string accountType, int balance) : base(accountNumber, holderName, accountType, balance)
        {
            _balance = balance;
            
        }

        public override void Withdraw(decimal amount)
        {
            if (((Balance + _odLimit) - amount) < 0)
            {
                Console.WriteLine($"Insuffient funds in CA, can withdraw upto: {Balance}");
                return;
                throw new InsufficientFundsException(AccountNumber, Balance, amount, $"Insuffient funds in CA, can withdraw upto: {Balance}");
            }
            else
            {
                Console.WriteLine($"Account balance {_balance}");
            }

        }

        public override void Display()
        {
            Console.WriteLine("Account balance = " + _balance);
        }
    }
}
