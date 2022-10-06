using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTwo
{
    internal class Student
    {
        // Properties
        private int id;
        private string name;

        // Constructor One
        public Student()
        {
            this.id = 0;
            this.name = null;
        }

        // Constructor Two
        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        // Getter and Setters
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


        //Methods
        public void PrintData()
        {
            Console.WriteLine($"{id} ; {name}");
        }
    }
}
