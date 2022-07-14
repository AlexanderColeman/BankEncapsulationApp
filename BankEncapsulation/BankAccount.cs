using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance = 0;

        public double Deposite(double dep)
        {
            return balance += dep;
        }

        public double Withdraw(double dep)
        {
            return balance -= dep;
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
