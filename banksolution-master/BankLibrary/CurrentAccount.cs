using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
  [Serializable]//-- Attributes
  public class CurrentAccount: Account
  {
    readonly decimal _odLimit;
    public CurrentAccount(int accountNumber, string holdersName, decimal balance, decimal odLimit) : base(accountNumber, holdersName, balance)
    {
      _odLimit = odLimit;
    }

    public CurrentAccount(int accountNumber, string holdersName, decimal balance) : this(accountNumber, holdersName, balance, 0)
    {}

    public override void Withdraw(decimal amount)
    {
      if (amount <= 0)
      {
        throw new NegativeException("Transaction amount cannot be less than 1");
      }
      if (((Balance + _odLimit) - amount) < 0)
      {
        throw new InsufficientFundsException(AccountNumber, Balance, amount, $"Insuffient funds in CA, can withdraw upto: {Balance}");

        //throw new ArgumentException($"Insuffient funds in CA, can withdraw upto: {Balance}");
      }
      Balance -= amount;
      //Step III
      if (WBalanceChanged != null)
      {
        WBalanceChanged(AccountNumber, Balance, amount, "Withdraw");
      }
    }
  }
}
