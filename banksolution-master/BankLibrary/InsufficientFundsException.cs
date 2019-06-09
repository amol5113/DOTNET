using System;
using System.IO;
namespace BankLibrary
{
  public class InsufficientFundsException: ApplicationException
  {
    int _accountNumber;
    decimal _currentBalance;
    decimal _transactionAmount;

    public InsufficientFundsException(int accountNumber, decimal currentBalance, decimal transactionAmount, string message) : base(message)
    {
      _accountNumber = accountNumber;
      _currentBalance = currentBalance;
      _transactionAmount = transactionAmount;

      StreamWriter sWriter = new StreamWriter("InsufficentFundsLog.txt", true);
      sWriter.WriteLine($"{_accountNumber}|{_currentBalance}|{_transactionAmount}|{DateTime.Now}");
      sWriter.Flush();
      sWriter.Close();
    }

    public int AccountNumber
    {
      get
      {
        return _accountNumber;
      }
    }

    public decimal CurrentBalance
    {
      get
      {
        return _currentBalance;
      }
    }
    public decimal TransactionAmount
    {
      get
      {
        return _transactionAmount;
      }
    }

  }
}
