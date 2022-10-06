using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTwo
{
    internal class Doctor : Employee // Inheritance
    {
        public override void DataType()
        {
            Console.WriteLine("Doctor");
        }
    }
}
