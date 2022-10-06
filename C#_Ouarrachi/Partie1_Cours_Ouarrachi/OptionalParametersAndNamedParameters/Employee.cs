using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParametersAndNamedParameters
{
    internal class Employee
    {
        public void AddEmployeeInfo(int empId, string name, bool isPermanent, string mobile, string departement)
        {
            // Here all parameters are required
            Console.WriteLine($"Emplyee Id : {empId}\nName Employee : {name}\nPermanent : {isPermanent}\nMobile Employee : {mobile}\nDepartement Employee : {departement}");

        }
        // the optional parameters must have appeared after all the required parameters in the parameter list .
        public void AddEmployeeInfoOne(int empId, string name, string mobile, bool isPermanent = true,  string departement = "IT")
        {
            // Here empId and name and mobile are required parameters , isPermanent and departement are optional parameters
            Console.WriteLine($"Emplyee Id : {empId}\nName Employee : {name}\nPermanent : {isPermanent}\nMobile Employee : {mobile}\nDepartement Employee : {departement}");

        }
        
    }
}
