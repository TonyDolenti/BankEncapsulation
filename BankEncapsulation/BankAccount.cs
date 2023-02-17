using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance = 0;

        public double Deposit(double depositamount)
        {
            return _balance += depositamount;
            
        }

        public double GetBalance()
        {
            return _balance;
        }

    }
}
