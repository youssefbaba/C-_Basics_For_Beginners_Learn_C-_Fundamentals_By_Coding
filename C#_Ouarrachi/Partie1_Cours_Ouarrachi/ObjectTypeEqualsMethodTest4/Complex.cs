using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTypeEqualsMethodTest4
{
    internal class Complex
    {
        // fields
        public double re;
        public double im;

        // constructor
        public Complex(double re ,double im)
        {
            this.re = re;
            this.im = im;
        }

        public override bool Equals(object obj)
        {
            // this = complex1 = (4.2,1.2)
            // obj = complex2 = (4.2,1.2)
            // Console.WriteLine(obj.GetType()); // Complex
            return obj is Complex && this == (Complex)obj;
        }
        public override int GetHashCode()
        {
            return Tuple.Create(re, im).GetHashCode();
        }
        public static bool operator ==(Complex x , Complex y)
        {
            // x = this = (4.2,1.2)
            // y = obj = (4.2,1.2)
            return x.re == y.re && x.im == y.im;
        }
        public static bool operator !=(Complex x, Complex y)
        {
            // x = complex1 = (4.2,1.2)
            // y = complex2 = (2.1,1.2)
            return !(x == y);
        }
        public override string ToString()
        {
            return $"({re},{im})" ;
        }
    }
}
