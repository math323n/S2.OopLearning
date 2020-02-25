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
    /// 
    /// </summary>
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

       
        public override string ToString()
                => $"Fornavn: {firstName}\tEfternavn: {lastName}\tCPR: {cpr}\tFødselsdato: {birthday}";
    }
}