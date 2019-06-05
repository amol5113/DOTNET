using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class Account
    {
        int _accountNumber;
        string _holderName;
        string _accountType;
        int _balance;
        public Account(int accountNumber, string holderName, string accountType, int balance)
        {
            _accountNumber = accountNumber;
            _holderName = holderName;
            _accountType = accountType;
            _balance = balance;

        }

        public void Deposit(int amount) {
            _balance += amount;
            Console.WriteLine("Account balance after deposit = " + _balance);
        }

        public void SavingAcc(int amount)
        {
            if ((_balance - amount) > 0)
            {
                _balance -= amount;
                Console.WriteLine("Account balance after withdraw = " + _balance);
            }
            else {
                Console.WriteLine($"your balance is{_balance} enter valid amount" );
            }
            
        }

        public void CurrentAcc(int amount)
        {   
            if ((_balance - amount) > 500)
            {
                _balance -= amount;
                Console.WriteLine("Account balance after withdraw = " + _balance);
            }
            else
            {
                Console.WriteLine($"your balance is{_balance-500} enter valid amount");
            }

        }

        public void Display()
        {
            Console.WriteLine("Account balance = " + _balance);
        }
    }
}
