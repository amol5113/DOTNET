﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
  public class WithdrawNotSupportedException : ApplicationException
  {
    public WithdrawNotSupportedException(string message) : base(message) { }
  }
}
