using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversions
{
    internal class Student
    {
        public string name { get; set; }
        public int age { get; set; }

        // This method used to convert int value into 'Student' type  
        public static implicit operator Student (int value)
        {
            // Return type of this method should be of 'Student' type  
            return new Student { name = "youssef", age = value };
        }

        // This method used to convert 'Student' type value into 'int' type  
        public static explicit operator int(Student student)
        {
            // Return type of this method should be of 'int' type  
            return student.age;
        }



    }
}
