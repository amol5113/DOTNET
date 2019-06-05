using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BankLibrary;
namespace BankClientConApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1234,"amol","current",100000);
            acc.Display();
            acc.Deposit(100);
            acc.SavingAcc(20000);
            acc.CurrentAcc(20000000);
            acc.Display();
            
        }
    }
}
