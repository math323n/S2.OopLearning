using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace S2.OopLearning.BL
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private DateTime birthday;
        private string cpr;

        public Person()
        {

        }

        public string FirstName
        {
            get => FirstName;
            set
            {
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name is null, empty or whitespace", nameof(FirstName));
                }
                if(value.Any(c => Char.IsDigit(c)))
                {
                    throw new ArgumentException("Name must not contain numbers", nameof(FirstName));
                }
                if(value != FirstName)
                {
                    FirstName = value;
                }
            }
        }
        public string LastName
        {
            get => LastName;
            set
            {
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name is null, empty or whitespace", nameof(LastName));
                }
                if(value.Any(c => Char.IsDigit(c)))
                {
                    throw new ArgumentException("Name must not contain numbers", nameof(LastName));
                }
                if(value != LastName)
                {
                    LastName = value;
                }
            }
        }

        public string Cpr
        {
            get
            {
                return cpr;
            }
            set
            {
                cpr = value;
            }
        }



        public static (bool, string) ValidateName(string name)
        {
            if(name.Length <= 1)
            {
                return (false, "Navnet må ikke være under 1 cifre.");
            }
            if(string.IsNullOrWhiteSpace(name))
            {
                return (false, "Navnet er NULL, eller indeholder kun WHITESPACE");
            }
            else
            {
                return (true, String.Empty);
            }
        }

        public static (bool, string) ValidateCpr(string cpr)
        {
            if(string.IsNullOrWhiteSpace(cpr))
            {
                return (false, "CPR nummeret er NULL, eller indeholder kun WHITESPACE");
            }
            else if(cpr.Length > 10)
            {
                return (false, "CPR nummeret må ikke være over 10 cifre.");
            }
            else if(cpr.Length <= 0)
            {
                return (false, "CPR nummeret må ikke være under 0 cifre");
            }
            else
            {
                return (true, String.Empty);
            }
        }
    

        public enum Gender
        {
            Male,
            Female,
            Autist,
            Unspecified
        }

    }
}