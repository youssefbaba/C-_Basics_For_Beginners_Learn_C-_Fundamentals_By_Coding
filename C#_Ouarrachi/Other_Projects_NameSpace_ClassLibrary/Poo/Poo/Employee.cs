using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooOne
{
    internal class Employee
    {
        private int id;
        private string name;
        private double salary;

        // Getter and Setter

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Salary
        {
            get { return salary; }
            set 
            {
                if (value < 1500 )
                {
                    salary = 1500;
                }
                else 
                {
                    salary = value;
                }
               
                
            }
        }

        private string MyPrintData()
        {
            return $"{id};{name};{salary}";
        }
        public void PrintData()
        {
            Console.WriteLine(MyPrintData().Replace(";", "\n"));
        }
        
    }
}
