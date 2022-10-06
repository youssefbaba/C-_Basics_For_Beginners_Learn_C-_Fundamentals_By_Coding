using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversionsParseAndTryParse
{
    internal class Employee : IEmployee
    {
        public virtual void Display()
        {
            Console.WriteLine("Display Employee");
        }
    }
}
