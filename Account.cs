using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Account
    {
        public float Balance { get; private set; }

        public void Deposit(float amount)
        {
            if (amount > 0)
                Balance += amount;
        }

        public void Withdraw(float amount)
        {
            if (amount > 0)
            {
                Balance -= amount;
            }
        }
    }
}