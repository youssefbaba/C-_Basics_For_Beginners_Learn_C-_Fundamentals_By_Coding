using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTypeEqualsMethodTest4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex complex1 = new Complex(4.2,1.2);
            Complex complex2 = new Complex(2.1,1.2);

            Console.WriteLine($"{complex1} = {complex2} : {complex1 != complex2}");
            // {complex1} = complex1.ToString() = (4.2,1.2)
            // {complex2} = complex2.ToString() = (2.1,1.2)
            // {complex1 != complex2} = True
            // (4.2,1.2) = (2.1,1.2) : True




            Console.WriteLine($"{complex1} = {complex2} : {complex1.Equals(complex2)}");
            // {complex1} = complex1.ToString() = (4.2,1.2)
            // {complex2} = complex2.ToString() = (2.1,1.2)
            // { complex1.Equals(complex2)} = False 
            // (4.2,1.2) = (2.1,1.2) = False




            complex2.re = 4.2;




            Console.WriteLine($"{complex1} = {complex2} : {complex1 == complex2}");
            // {complex1} = complex1.ToString() = (4.2,1.2)
            // {complex2} = complex2.ToString() = (4.2,1.2)
            // {complex1 == complex2} =  True
            // (4.2,1.2) = (4.2,1.2) : True




            Console.WriteLine($"{complex1} = {complex2} : {complex1.Equals(complex2)}");
            // {complex1} = complex1.ToString() = (4.2,1.2)
            // {complex2} = complex2.ToString() = (4.2,1.2)
            // {complex1.Equals(complex2)} = True
            // (4.2,1.2) = (4.2,1.2) : True


        }
    }
}
