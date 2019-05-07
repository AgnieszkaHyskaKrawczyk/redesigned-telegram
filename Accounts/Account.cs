using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    class Account
    {
        private string accNumber;
        public string AccNumber
        {
            get { return accNumber; }
        }

        private string accOwner;
        public string AccOwner
        {
            get { return accOwner; }
            set { accOwner = value; }
        }

        private double accBalance = 0;
        public double AccBalance
        {
            get { return accBalance; }
            private set { accBalance = value; }
        }

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
