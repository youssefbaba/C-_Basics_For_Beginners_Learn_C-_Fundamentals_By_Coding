using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParametersAndNamedParameters
{
    internal class PersonalDetails
    {
        public void AddPersonalDetails(string firstName , string lastName , string petName , string shortName)
        {
            Console.WriteLine($"FisrtName = {firstName}\nLastName = {lastName}\nPetName = {petName}\nShortName = {shortName} ");
        }
    }
}
