using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewApplication
{
    class Account
    {
        private Client client;
        private double balance;

        public Account(Client client, double balance)
        {
            this.client = client;
            this.balance = balance;
        }

        public double Balance { get => balance; set => balance = value; }
        public Client Client { get => client; set => client = value; }

        public double withdraw(double value)
        {
            if (value <= balance)
            {
                return balance -= value;
                
            } else
            {
                return 0;
            }
        }

        public void transfer(Account secondaryAccount, double value)
        {
            secondaryAccount.Balance += this.withdraw(value);
        }
    }
}
