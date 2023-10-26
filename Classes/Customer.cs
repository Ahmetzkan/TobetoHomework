﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Customer
    {

        public int Id { get; set; }
        private string _firstName;
        public string FirstName {
            get { return "Mrs. " + _firstName; } //FirstName önüne Mr. ekini getirir.
            set { _firstName = value; } //encapsulation
        }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
