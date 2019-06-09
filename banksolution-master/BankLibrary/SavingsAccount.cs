using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
  [Serializable]//-- Attributes
  public class SavingsAccount: Account
  {
    readonly decimal _minBalance;
    public SavingsAccount(int accountNumber, string holdersName, decimal balance): base(accountNumber, holdersName, balance)
    {
      _minBalance = 500;
      if (balance < _minBalance)
      {
        throw new OpeningBalanceException($"SA Opening balance cannot be less than - {_minBalance}");
      }
    }

    public override void Withdraw(decimal amount)
    {
      if (amount <= 0)
      {
        throw new NegativeException("Transaction amount cannot be less than 1");
      }
      if ((Balance - amount) < _minBalance)
      {
        throw new InsufficientFundsException(AccountNumber, Balance, amount, $"Insuffient funds in SA, can withdraw upto: {Balance - _minBalance}");

        //throw new ArgumentOutOfRangeException($"Insuffient funds in SA, can withdraw upto: {Balance - _minBalance}");
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
