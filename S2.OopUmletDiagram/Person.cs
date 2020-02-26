using System;
using System.Collections.Generic;
using System.Text;

namespace S2.OopUmletDiagram
{
    public class Person
    {
        private string firstName;
        private string lastName;

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName
        {
            get => firstName;
            set
            {
                if(value != firstName)
                {
                    firstName = value;
                }
            }
        }
        public string LastName
        {
            get => lastName;
            set
            {
                if(value != lastName)
                {
                    lastName = value;
                }
            }
        }
    }
}