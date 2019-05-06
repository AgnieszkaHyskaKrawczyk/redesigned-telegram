using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    class Account
    {
        public string accNumber;
        public string accOwner;
        public double accBalance;

        public Account(string accountNumber, string accountOwner)
        {
            accNumber = accountNumber;
            accOwner = accountOwner;
        }

        public void Increase(double amount)
        {
            accBalance += amount;
        }

        public bool Decrease(double amount)
        {
            if (accBalance >= amount)
            {
                accBalance -= amount;
                return true;

            }
            else
                return false;
        }
    }
}
