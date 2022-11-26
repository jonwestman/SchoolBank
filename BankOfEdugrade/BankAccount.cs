using System;
using System.Collections.Generic;
using System.Text;

namespace BankOfEdugrade
{
    public class BankAccount
    {
        public string Number { get; set; }
        public string Owner { get; set; }
        public decimal Balance { get; set; }
        readonly string Password;

        public BankAccount(string name, string password) { }
        public BankAccount(string name, string password,decimal initialBalance)
        {
            this.Owner = name;
            this.Balance = initialBalance;
            this.Password = password;
        }
        //Method for depositing money to accounts, both date/time and a note will be added
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {

        }
        //Method for withdrawing money from accounts, both date/time and a note will be added
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {

        }
    }
}
