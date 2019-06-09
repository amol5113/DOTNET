using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
  [Serializable] //-- Attributes
  public class FixedDeposit : Account
  {
    readonly decimal _openingFDBalance;
    public FixedDeposit(int accountNumber, string holdersName, decimal balance) : base(accountNumber, holdersName, balance)
    {
      _openingFDBalance = 3000;
      if (balance < _openingFDBalance)
      {
        throw new OpeningBalanceException($"FD Opening balance cannot be less than - {_openingFDBalance}");
      }
    }

    public override void Deposit(decimal amount)
    {
      throw new DepositNotSupportedException("Deposit Not Supported in FD");
    }
    public override void Withdraw(decimal amount)
    {
      throw new WithdrawNotSupportedException("Withdraw Not Supported in FD");
    }
  }
}
