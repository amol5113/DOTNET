using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BankLibrary;
namespace SavingAccount
{
    public class SavingAccount : Account
    {
        decimal _balance;
        readonly decimal _manBal;


        public override void Withdraw(int amount)
        {
            if ((_balance - amount) > 0)
            {
                _balance -= amount;
                Console.WriteLine("Account balance after withdraw = " + _balance);
                return;
            }
            else {
                Console.WriteLine($"Account balance {_balance}= ");
            }
            
        }
    }
}
