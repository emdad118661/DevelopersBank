using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopersBank
{
    class Account
    {
        public int accountNumber;
        public string accountName, email;
        public double balance;
        public double amount;
        //private Address Address;
        public int AccountNumber
        {
            set { this.accountNumber = value; }
            get { return this.accountNumber; }
        }
        public string AccountName
        {
            set { this.accountName = value; }
            get { return this.accountName; }
        }
        public string Email
        {
            set { this.email = value; }
            get { return this.email; }
        }
        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }
        public double Amount
        {
            set { this.amount = value; }
            get { return this.amount; }
        }
        public void Deposit(double amount)
        {
            this.balance += amount;
            Console.WriteLine("Deposit successfull.Your Current Balance:" + balance);
        }
        public void SavingsWithdraw(double amount)
        {
            if (balance - amount != 0)
            {
                if (balance >= amount)
                {
                    this.balance -= amount;
                    Console.WriteLine("Withdraw successfull.Your Current Balance:" + balance);
                }
                else
                    Console.WriteLine("You do not have sufficient balance");
            }
            else
                Console.WriteLine("Your balance cannot be 0,sorry");
                Console.WriteLine("******************************************");
        }
        public void CheckingWithdraw(double amount)
        {
            if (balance >= amount)
            {
                this.balance -= amount;
                Console.WriteLine("Withdraw successfull.Your Current Balance:" + balance);
            }
            else
                Console.WriteLine("You do not have sufficient balance");
        }
        public void Transfer(double amount, Account account)
        {
            if (balance >= amount)
            {
                this.balance -= amount;
                account.balance += amount;
                Console.WriteLine("Transfered Successfully! Your current balance:" + this.balance);
            }
            else
                Console.WriteLine("You do not have sufficient balance");
        }
        public void ShowAccountInfo()
        {
            Console.WriteLine("Account No:{0} \n Account Name:{1} \n Email:{2} \n Balance:{3}", AccountNumber, AccountName, Email, Balance);
        }
    }
}
