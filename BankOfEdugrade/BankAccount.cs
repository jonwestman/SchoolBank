using System;
using System.Collections.Generic;
using System.Text;

namespace BankOfEdugrade
{
    public class BankAccount
    {
        private static uint accountNumberSeed = 1234567890;
        public string Number { get;}
        public string Owner { get; set; }
        public decimal Balance { get; }

        public BankAccount(string name, decimal initalBalance)
        {
            this.Owner = name;
            this.Balance = initalBalance;
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {

        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {

        }
    }
}
