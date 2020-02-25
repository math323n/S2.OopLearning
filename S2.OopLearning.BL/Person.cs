using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;


namespace S2.OopLearning.BL
{
    public enum Gender
    {
        Male,
        Female,
        Autist,
        Skitzo
    }

    /// <summary>
    /// reates a new <see cref="Person"/> with the provided <see cref="firstName"/>, <see cref="lastName"/>, <see cref="cpr"/>
    ///  </summary>
    /// <param name="firstname">The persons firstname</param>
    /// <param name="lastname">The persons lastname</param>
    /// <param name="cpr">The persons CPR-number</param>
    /// <param name="gender">The persons gender</param>
    ///<exception cref="ArgumentException"></exception>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public class Person
    {
        private string firstName;
        private string lastName;
        private DateTime birthday;
        private string cpr;
        private Gender gender;

        public Person(string firstName, string lastName, string cpr, Gender gender)
        {
            Gender = gender;
            FirstName = firstName;
            LastName = lastName;
            Cpr = cpr;

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
                if(value != FirstName)
                {
                    firstName = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets the value of <see cref="lastName"/>
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
                    throw new ArgumentOutOfRangeException(nameof(LastName), validationResult.errorMessage);
                }
                if(value != lastName)
                {
                    lastName = value;
                }
            }
        }


        /// <summary>
        /// Gets orsets the value of<see cref= "cpr" />
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public string Cpr
        {
            get => cpr;
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateCpr(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentException(nameof(Cpr), validationResult.errorMessage);
                }
                if(value != cpr)
                {
                    cpr = value;
                }
            }
        }

        /// <summary>
        /// Gets the value of <see cref="birthday"/>
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public DateTime Birthday
        {
            get
            {
                (bool isValid, string errorMessage) validationResult = ValidateCpr(Cpr);
                if(!validationResult.isValid)
                {
                    throw new ArgumentOutOfRangeException(nameof(Birthday), validationResult.errorMessage);
                }
                else
                {
                    DateTime.TryParseExact(Cpr.Substring(0, 6), "ddMMyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date);

                    birthday = date;

                    return birthday;
                }
            }
        }

        /// <summary>
        /// Gets the value of <see cref="gender"/>
        /// </summary>
        public Gender Gender
        {
            get
            {
                return gender;
            }
            set
            {
                if(gender != value)
                {
                    gender = value;
                }
            }
        }

        /// <summary>
        /// Validates the persons name
        /// </summary>
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

        /// <summary>
        /// Validates the persons CPR number
        /// </summary>
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
            if(cpr.Any(c => Char.IsLetter(c)))
            {
                return (false, "CPR nummeret må ikke indeholde bogstaver.");
            }
            if(!DateTime.TryParseExact(cpr.Substring(0, 6), "ddMMyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                return (false, "De første 6 cifre er ugyldige.");
            }
            if(date > DateTime.Now)
            {
                return (false, "De første 6 cifre er en dato i fremtiden.");
            }
            else
            {
                return (true, String.Empty);
            }
        }
    }
}