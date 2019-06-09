using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
  //Step I
  public delegate void BalanceChanged(int accountNumber, decimal newBalance, decimal transactionAmount, string transactionType);
  [Serializable]//-- Attributes
  public abstract class Account
  {
    int _accountNumber;
    private string _holdersName;
    private decimal _balance;
    //Step II
    public BalanceChanged WBalanceChanged;
    public event BalanceChanged DBalanceChanged;
    public Account(int accountNumber, string holdersName, decimal balance)
    {
      _accountNumber = accountNumber;
      _holdersName = holdersName;
      _balance = balance;

    }

    public int AccountNumber
    {
      get
      {
        return _accountNumber;
      }
    }

    public string HoldersName
    {
      get
      {
        return _holdersName;
      }
      set
      {
        _holdersName = value;
      }
    }

    public decimal Balance
    {
      get
      {
        return _balance;
      }
      protected set
      {
        _balance = value;
      }
    }

    public virtual void Deposit(decimal amount)
    {
      if (amount <= 0)
      {
        throw new NegativeException("Transaction amount cannot be less than 1");
      }
      _balance += amount;
      if (DBalanceChanged != null)
      {
        DBalanceChanged(_accountNumber, _balance, amount, "Deposit");
      }
    }
    public abstract void Withdraw(decimal amount);

    public override string ToString()
    {
      return $"Account Number: {_accountNumber}, HoldersName: {_holdersName} and Balance: {_balance}";
    }
  }
}
