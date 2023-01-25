using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingEssentials.Models
{
    public class Person
    {
        //DECLARING PUBLIC OBJECT VARIABLES
        public string name { get; set; }
        public int age { get; set; }
        public string lastName { get; set; }

        //DECLARING PRIVATE OBJECT VARIABLES
        public bool legalAge { get; set; }


        //DECLARING OBJECT CONSTRUCTOR
        public Person(string name, int age, string lastName)
        {
            this.name = name;
            this.age = age;
            this.lastName = lastName;
            legalAge = validateLegalAge();
        }

        //OVERRIDING FUNCTIONS
        public override string ToString()
        {
            return $"Name: {name}\nLast name: {lastName}\nAge:{age}";
        }

        //OBJECT VOID FUNCTIONS
        public bool validateLegalAge()
        {
            if (age < 18)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
