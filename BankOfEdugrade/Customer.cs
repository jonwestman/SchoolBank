using System;
using System.Collections.Generic;
using System.Text;

namespace BankOfEdugrade
{
    class Customer:Persons
    {
        private uint _accountNumber { get; set; }
        private double _amount { get; set; }
        public Customer (string name, string id, string password, uint accountNumber)
        {
            this.name = name;
            this.id = id;
            this.password = password;
            this._accountNumber = accountNumber;
        }
        public Customer()
        {
            
        }
        public double amount
        {
            get { return _amount; }
            set { _amount = value; }
        }


    }
}
