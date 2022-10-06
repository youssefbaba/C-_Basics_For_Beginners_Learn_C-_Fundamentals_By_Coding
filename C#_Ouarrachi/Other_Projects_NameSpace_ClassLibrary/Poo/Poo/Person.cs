using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooOne
{
    internal class Person
    {
        //Fields
        public int id;
        private string name;

        // Methods
        public void Print1() {
            Console.WriteLine("Hiho 1");
        }
        private void Print2() {
            Console.WriteLine("Hiho 2");
        }
        private void Print3()
        {
            Console.WriteLine("Hiho 3");
        }
    }
}
