using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankLibrary;
namespace BankClientConApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Account acc = new SavingAccount(1234,"amol","saving",10000);
            
            acc.Display();
            acc.Withdraw(500);
            acc.Display();

        }
    }
}
