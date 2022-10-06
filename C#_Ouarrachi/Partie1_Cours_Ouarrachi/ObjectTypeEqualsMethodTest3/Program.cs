using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTypeEqualsMethodTest3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(0,0,100,200);
            Rectangle r2 = new Rectangle(0,0,100,200);
            Rectangle r3 = new Rectangle(0,0,150,200);



            Console.WriteLine($"{r1} = {r2} : {r1.Equals(r2)}");
            // {r1} = r1.ToString() = Rectangle(0,0,100,200)
            // {r2} = r2.ToString() = Rectangle(0,0,100,200)
            // {r1.Equals(r2)} = (0,0,100,200).Equals((0,0,100,200)) = True
            // Rectangle(0,0,100,200) = Rectangle(0,0,100,200) : True




            Console.WriteLine($"{r1} = {r3} : {r1.Equals(r3)}");
            // {r1} = r1.ToString() = Rectangle(0,0,100,200)
            // {r3} = r3.ToString() = Rectangle(0,0,150,200)
            // {r1.Equals(r3)} = (0,0,100,200).Equals((0,0,150,200)) : False




            Console.WriteLine($"{r2} = {r3} : {r2.Equals(r3)}");
            // {r2} = r2.ToString() = Rectangle(0,0,100,200)
            // {r3} = r3.ToString() = Rectangle(0,0,150,200)
            // {r2.Equals(r3)} = (0,0,100,200).Equals((0,0,150,200))
            // Rectangle(0,0,100,200) = Rectangle(0,0,150,200) : False
        }
    }
}
