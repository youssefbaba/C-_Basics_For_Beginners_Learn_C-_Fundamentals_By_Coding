﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTypeEqualsMethodTest7
{
    public struct Person
    {
        private string firstName;
        public string lastName;

        public Person(string firstName , string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
