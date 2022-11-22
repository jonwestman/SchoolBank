using System;
using System.Collections.Generic;
using System.Text;

namespace BankOfEdugrade
{
    public class Persons
    {
        private string _name { get; set; }
        private string _id { get; set; }
        private string _password { get; set; }

        public Persons ()
        {

        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

    }
}
