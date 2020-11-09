using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Task_6
{
    class Account
    {
        private string accName;

        public string AccName
        {
            get { return accName; }
            set { accName = value; }
        }
        private string accId;

        public string AccId
        {
            get { return accId; }
            set { accId = value; }
        }
        private int balance;

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public Account() { }
        public Account(string accName,string accId,int balance)
        {
            this.accName = accName;
            this.accId = accId;
            this.balance = balance;

        }

        public void Deposit(int amount)
        {
            if(amount>=0)
            {
                balance = balance + amount;
                Console.WriteLine("New current balance : " + balance);
            }
            else
            {
                Console.WriteLine("Amount number can't be negative");
            }
        }
        public void Withdraw(int amount)
        {
            if(amount>=0 && balance>=amount)
            {
                balance = balance - amount;
                Console.WriteLine("New current balance : " + balance);
            }
        }

        public void Transfer(int amount , Account Receiver)
        {
            if(amount>=0 && balance>=amount)
            {
                balance = balance - amount;
               
            }
        }



    }
}
