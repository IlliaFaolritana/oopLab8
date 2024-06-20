
using System;
using System.Collections;

namespace OOPlr8
{
    class Wallet
    {
        private readonly List<Account> accounts;

        public Wallet()
        {
            accounts = new List<Account>();
        }
        public List<Account> Accounts 
        {
            get { return accounts; }
            private set { }
        }
        public void AddAccount(Account account)
        {
            Accounts.Add(account);
        }
        public void RemoveAccount(Account account)
        {
            if (!Accounts.Remove(account))
                throw new ArgumentException($"Account {account} does not exist");
        }
    }
}
