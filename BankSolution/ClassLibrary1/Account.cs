using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class Account
    {
        private int _accountNumber;
        private string _holderName;
        private decimal _balance;
        private string _accountType;

        public void AcceptDetails() {
            Console.WriteLine("Entere the Account Number");
            _accountNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entere the Account Holder Name");
            _holderName = Console.ReadLine();
            Console.WriteLine("Entere the Account Type");
            _accountType = Console.ReadLine();
            Console.WriteLine("Entere the Account Balance");
            _balance = Convert.ToDecimal(Console.ReadLine());

        }

        public void DisplayDetails() {
            Console.WriteLine("Account Number" + _accountNumber);
            Console.WriteLine("Account Holder name {0} , Account Type {1}" , _holderName ,_balance);
            Console.WriteLine("Account Balance" + _accountType);

        }
    }
}
