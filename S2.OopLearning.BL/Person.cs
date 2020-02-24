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

        public Person(string firstName, string lastName, string cpr)
        {
            FirstName = firstName;
            LastName = lastName;
            Cpr = cpr;
        }

        public string FirstName
        {
            get => firstName;
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateName(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentOutOfRangeException(nameof(FirstName), validationResult.errorMessage);
                }
                if(value != FirstName)
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
                (bool isValid, string errorMessage) validationResult = ValidateName(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentOutOfRangeException(nameof(LastName), validationResult.errorMessage);
                }
                if(value != lastName)
                {
                    lastName = value;
                }
            }
        }

        public string Cpr
        {
            get => cpr;
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateCpr(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentOutOfRangeException(nameof(LastName), validationResult.errorMessage);
                }
                if(value != cpr)
                {
                    cpr = value;
                }
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
            if(cpr.Length != 10)
            {
                return (false, "CPR nummeret skal være på 10 cifre.");
            }  
            else
            {
                return (true, String.Empty);
            }
        }

       
        public override string ToString()
                => $"Fornavn: {firstName}\tEfternavn: {lastName}\tCPR: {cpr}";

        public enum Gender
        {
            Male,
            Female,
            Autist,
            Unspecified
        }

    }
}