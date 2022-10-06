using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversions
{
    public readonly struct Digit
    {
        // Fields
        private readonly byte digit;

        // Constructor
        public Digit(byte digit)
        {
            if (digit > 9)
            {
                throw new ArgumentOutOfRangeException(nameof(digit), "Digit cannot be greater than nine.");
            }
            this.digit = digit;
        }

        public static explicit operator byte(Digit d)
        {
            return d.digit;
        }

        public static implicit operator Digit(byte number)
        {
            return new Digit(number);
        }
        public override string ToString()
        {
            return $"{this.digit}";
        }



    }
}
