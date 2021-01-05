using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopersBank
{
    class BankTrans
    {
        private string bankName;
        public Account[] accounts;



        public void Bank(string bankName, int size)
        {
            this.bankName = bankName;
            this.accounts = new Account[size];
        }
        public void AddAccount(Account account)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    accounts[i] = account;
                    break;
                }
            }
        }
        public void DeleteAccount(Account account)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] != null)
                {
                    accounts[i] = null;
                    break;
                }
            }
        }
        public void Transaction(Account account)
        {
            try
            {
                account.Deposit(100.0);
                account.SavingsWithdraw(100.0);
                account.CheckingWithdraw(100.0);
                account.Transfer(100.0, account);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("String is null");
            }
        }
        public void PrintAccountDetails(int accountNo)
        {
            try
            {
                for (int i = 0; i < accounts.Length; i++)
                {
                    if (accounts[i].AccountNumber == accountNo)
                    {
                        accounts[i].ShowAccountInfo();
                        break;
                    }
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("String is null");
            }
        }
    }
}
