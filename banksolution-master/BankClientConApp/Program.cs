using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using BankLibrary;



namespace BankClientConApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Account acc = null;
      try
      {
        //acc = new SavingsAccount(301, "Tintin", 2000);
        //acc = new CurrentAccount(102, "Snowy", 2000, 700);
        //acc = new FixedDeposit(102, "Thomson", 2000);

        //Step II of client
        //acc.WBalanceChanged += new BalanceChanged(SMSAlert);
        //acc.WBalanceChanged += new BalanceChanged(EmailAlert);
        //acc.DBalanceChanged += SMSAlert;
        //acc.DBalanceChanged += EmailAlert;
        acc = DeSerializeAccount("Tintin");
        Console.WriteLine("Got data from File");
        Console.WriteLine(acc);
        acc.Deposit(1000);
        Console.ReadKey(true);
        acc.Withdraw(800);
        SerializeAccount(acc);
        return;
      }
      catch (OpeningBalanceException ex)
      {
        Console.WriteLine(ex.ToString());
        return;
      }
      catch (NegativeException ex)
      {
        Console.WriteLine(ex.ToString());
        return;
      }
      catch (WithdrawNotSupportedException ex)
      {
        Console.WriteLine(ex.ToString());
        return;
      }
      catch (DepositNotSupportedException ex)
      {
        Console.WriteLine(ex.ToString());
        return;
      }
      catch (InsufficientFundsException ex)
      {
        Console.WriteLine(ex.ToString());
        Console.WriteLine($"Account Number: {ex.AccountNumber}, Current Balance: {ex.CurrentBalance}, Transaction Amount: {ex.TransactionAmount}");
        return;
      }
      catch (Exception ex)
      {
        //Console.WriteLine(ex.Message);
        //Console.WriteLine(ex.StackTrace);
        Console.WriteLine(ex.ToString());
        return;
      }
      finally
      {
        Console.WriteLine("Finally Bye");
      }
      //Console.WriteLine("Bye Bye"); //unreachable because of return
    }




    //Step I of client
    static void SMSAlert(int accountNumber, decimal newBalance, decimal transactionAmount, string transactionType)
    {
      Console.WriteLine($"SMS Alert....\nTransaction Type: {transactionType}\nAccount Number: {accountNumber}, Transaction Amount: {transactionAmount},\n New Balance: {newBalance}");
      Console.WriteLine("-----------------");
    }

    static void EmailAlert(int accountNumber, decimal newBalance, decimal transactionAmount, string transactionType)
    {
      Console.WriteLine($"Email Alert....\nTransaction Type: {transactionType}\nAccount Number: {accountNumber}, Transaction Amount: {transactionAmount},\n New Balance: {newBalance}");
      Console.WriteLine("-----------------");
    }


    static void SerializeAccount(Account account)
    {
      FileStream fStream = null;
      try
      {
        fStream = new FileStream($"{account.HoldersName}.dat", FileMode.Create, FileAccess.Write);
        BinaryFormatter bFormatter = new BinaryFormatter();
        bFormatter.Serialize(fStream, account);
        Console.WriteLine($"{account.HoldersName} file is saved");
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.ToString());
      }
      finally
      {
        fStream.Flush();
        fStream.Close();
      }
    }

    static Account DeSerializeAccount(string filename)
    {
      FileStream fStream = null;
      try
      {
        fStream = new FileStream($"{filename}.dat", FileMode.Open, FileAccess.Read);
        BinaryFormatter bFormatter = new BinaryFormatter();
        return (Account)bFormatter.Deserialize(fStream);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.ToString());
        return null;
      }
      finally
      {
        fStream.Flush();
        fStream.Close();
      }
    }

  }
}