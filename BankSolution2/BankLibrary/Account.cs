using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    //public class Account
    public abstract class Account
    {
        int _accountNumber;
        string _holderName;
        string _accountType;
        decimal _balance;
        public Account(int accountNumber, string holderName, string accountType, int balance)
        {
            _accountNumber = accountNumber;
            _holderName = holderName;
            _accountType = accountType;
            _balance = balance;

        }

        public int AccountNumber
        {
            get
            {
                return _accountNumber;
            }
        }

        public string HolderName
        {
            get
            {
                return _holderName;
            }
        
            set
            {
                _holderName = value;
            }
        }

        public string AccountType
        {
            get
            {
                return _accountType;
            }
            set
            {
                _accountType = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance =  value;

            }
        }
       // public void Withdraw(decimal amount)
        public abstract void Withdraw(decimal amount);

        public void Deposit(int amount)
        {
            _balance += amount;
            Console.WriteLine("Account balance after deposit = " + _balance);
        }

        

        public virtual void Display()
        {
            Console.WriteLine("Account balance = " + _balance);
        }
    }

}

