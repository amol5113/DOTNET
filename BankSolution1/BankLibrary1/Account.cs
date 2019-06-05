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
        Account(int accountNumber,string holderName,string accountType,int balance) {
            _accountNumber = accountNumber;
            _holderName = holderName;
            _accountType = accountType;
            _balance = balance;

        }
    }
}
