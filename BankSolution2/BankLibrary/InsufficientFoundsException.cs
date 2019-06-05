using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    class InsufficientFoundsException : ApplicationException
    {
        int accountNumber;
        decimal _currentBalance;
        decimal _transactionAmount;

        InsufficientFoundsException(int accountNumber, decimal currentBalance, decimal transactionAmount,string message) : base(message)
        {

        }
    }
}
