using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTwo
{
    internal class Employee : Person // Inheritance
    {
        private string idEmployee;

        public string IdEmployee
        {
            get { return idEmployee; }
            set { idEmployee = value; } 
        }

        // Overriding Method
        public override void DataType()
        {
            Console.WriteLine("Employee");
        }

    }
}
