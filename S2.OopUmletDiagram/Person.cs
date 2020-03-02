using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace S2.OopUmletDiagram
{
    /// <summary>
    /// Class for person
    /// </summary>
    /// <param name="id">The persons ID</param>
    /// <param name="firstname">The persons firstname</param>
    /// <param name="lastname">The persons lastname</param>
    /// <param name="birthdate">The persons birthdate</param>
    ///<exception cref="ArgumentException"></exception>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public class Person
    {
        private int id;
        private string firstName;
        private string lastName;
        private DateTime birthdate;
        private ContactInformation contactInformation;


        public Person(int id, string firstName, string lastName, DateTime birthdate, ContactInformation contactInformation)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Birthdate = birthdate;
            ContactInformation = contactInformation;
        }

        /// <summary>
        /// Gets or sets value of <see cref="id"/>
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public int Id
        {
            get => id;
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateId(value);
                if(!validationResult.isValid)
                {
                    
                }
                if(value != id)
                {
                    id = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets value of <see cref="firstName"/>
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
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

        /// <summary>
        /// Gets or sets value of <see cref="lastName"/>
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
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

        /// <summary>
        /// Gets or sets value of <see cref="birthdate"/>
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public DateTime Birthdate
        {
            get => birthdate;
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateBirthdate(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentOutOfRangeException(nameof(Birthdate), validationResult.errorMessage);
                }
                if(value != birthdate)
                {
                    birthdate = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets value of <see cref="contactInformation"/>
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public ContactInformation ContactInformation
        {
            get => contactInformation;
            set
            {
                (bool isValid, string errorMessage) = ValidateContactInformation(value);
                if(!isValid)
                {
                    throw new ArgumentException(errorMessage, nameof(ContactInformation));
                }
                if(contactInformation != value)
                {
                    contactInformation = value;
                }
            }
        }

        /// <summary>
        /// Calculates the age of the person
        /// </summary>
        /// <param name="dateOfBirth"></param>
        /// <returns></returns>
        public int CalculateAge(DateTime dateOfBirth)
        {
            int age = DateTime.Now.Year - dateOfBirth.Year;
            if(DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }

        /// <summary>
        /// Validates the persons birthdate, must not be in the future
        /// </summary>
        /// <param name="date"></param>
        public static (bool, string) ValidateBirthdate(DateTime date)
        {
            if(date > DateTime.Now)
            {
                return (false, "Datoen er i fremtiden.");
            }
            if(date == new DateTime(0001, 01, 01))
            {
                return (false, "Datoen er ugyldig.");
            }
            else
            {
                return (true, String.Empty);
            }
        }

        /// <summary>
        /// Validates the name of the person, must not be null or whitespace or less <= 1
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static (bool, string) ValidateName(string name)
        {
            if(name.Length <= 1)
            {
                return (false, "Nanvet skal være 2 cifre eller mere.");
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

        /// <summary>
        /// Validates the ID of the person, ID must not be <= 0
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static (bool, string) ValidateId(int id)
        {
            if(id <= 0)
            {
                return (false, "\"ID\" må ikke være 0 eller derunder.");
            }
            else
            {
                return (true, String.Empty);
            }
        }

        /// <summary>
        /// Validates the contact information
        /// </summary>
        /// <param name="contactInformation"></param>
        /// <returns></returns>
        public static (bool, string) ValidateContactInformation(ContactInformation info)
        {
            if(string.IsNullOrEmpty(info.Email))
            {
                return (false, "Værdien \"Email\" må ikke være NULL eller indeholde kun WHITESPACE");
            }
            if(string.IsNullOrEmpty(info.PhoneNumber))
            {
                return (false, "Værdien \"PhoneNumber\" må ikke være NULL eller indeholde kun WHITESPACE");
            }
            else
            {
                return (true, string.Empty);
            }
        }
        /// <summary>
        /// Overriding ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
            => $"ID: {id}\nFornavn: {firstName}\nEfternavn: {lastName}\nFødselsdato: {birthdate.ToString("dd/MM/yyyy")}\n" +
            $"Email: {ContactInformation.Email}\nTelefon: {ContactInformation.PhoneNumber}";

    }
}