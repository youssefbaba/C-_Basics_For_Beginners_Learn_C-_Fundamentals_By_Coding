using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Person p1 = new Person();
            p1.id = 2;
            p1.Print1();
            */


            Employee emp1 = new Employee();
            emp1.Id = 1;    // Setter
            emp1.Name = "Youssef";  // Setter
            emp1.Salary = 1100;   // Setter
            emp1.Id = 5;    // Setter
            Console.WriteLine(emp1.Id); // Getter
            emp1.PrintData();
            
        }
    }
}
