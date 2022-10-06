using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Customer c1 = new Customer();
            Employee e1 = new Employee();
            Doctor d1 = new Doctor();
            p1.Name = "Youssef";
            p1.Address = "Casablanca 09 Sidi Moumen Maroc";
            p1.Phone = "0654854854";
            Console.WriteLine(p1.GetPersonData());
            Console.WriteLine(p1.GetPersonData(" ; "));
            Console.WriteLine(p1.GetPersonData(" ; " , " : This is the person data."));


            Student std1 = new Student();
            Student std2 = new Student(1, "Hassna");
            std1.PrintData();
            std2.PrintData();

            p1.DataType(); // Person
            c1.DataType(); // Customer
            e1.DataType(); // Employee
            d1.DataType(); // Doctor

        }
    }
}
