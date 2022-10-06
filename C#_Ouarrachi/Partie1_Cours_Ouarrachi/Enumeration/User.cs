using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    /*
     - 0 => Unknown
     - 1 => Male
     - 2 => Female
     */
    internal class User
    {
        // Fields
        public string? Name { get; set; }
        //public int Gender { get;set; } // with enum
        public Gender Gender { get; set; } // with enum
    }
}
