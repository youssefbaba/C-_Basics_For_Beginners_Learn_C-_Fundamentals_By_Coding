using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTwo
{
    internal class Customer : Person   // Inheritance
    {
        private string shipmentAddress;
        
        public string ShipmentAddress
        {
            get { return shipmentAddress; }
            set { shipmentAddress = value; }
        }

        // Overriding Method
        public override void DataType() 
        {
            Console.WriteLine("Customer");
        }

    }
}
