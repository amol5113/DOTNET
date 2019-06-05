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
            Account acc = new Account();
            acc.AcceptDetails();
            acc.DisplayDetails();

        }
    }
}
