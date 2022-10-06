using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversionsParseAndTryParse
{
    internal class Customer : Employee
    {
       public override void Display()
        {
            Console.WriteLine("Display Customer");
        }
    }
}
