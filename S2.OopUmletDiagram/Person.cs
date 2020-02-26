using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace S2.OopUmletDiagram
{
    public class Person
    {
        private int id;
        private string firstName;
        private string lastName;
        private DateTime birthdate;

        public Person(int id, string firstName, string lastName, DateTime birthdate)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Birthdate = birthdate;
        }
        public int Id
        {
            get => id;
            set
            {
                if(value != id)
                {
                    id = value;
                }
            }
        }

        public string FirstName
        {
            get => firstName;
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateName(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentException(nameof(FirstName), validationResult.errorMessage);
                }
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
                (bool isValid, string errorMessage) validationResult = ValidateName(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentException(nameof(LastName), validationResult.errorMessage);
                }
                if(value != lastName)
                {
                    lastName = value;
                }
            }
        }

        public DateTime Birthdate
        {
            get => birthdate;    
            set
            {
                if(value != birthdate)
                {
                    birthdate = value;
                }
            }
        }

        public int CalculateAge(DateTime dateOfBirth)
        {
            int age = DateTime.Now.Year - dateOfBirth.Year;
            if(DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
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
            if(name.Any(c => Char.IsDigit(c)))
            {
                return (false, "Navnet må ikke indeholde tal.");
            }
            else
            {
                return (true, String.Empty);
            }
        }
        public static (bool, string) ValidateId(int id)
        {
            if(id <= 0)
            {
                return (false, "ID må ikke være 0 eller derunder.");
            }
            else
            {
                return (true, String.Empty);
            }
        }
        public override string ToString()
            =>$"ID: {id}\nFornavn: {firstName}\nEfternavn: {lastName}\nFødselsdato: {birthdate.ToString("dd/MM/yyyy")}";
        
    }
}