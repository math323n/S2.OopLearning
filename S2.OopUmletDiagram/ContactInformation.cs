using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace S2.OopUmletDiagram
{
    /// <summary>
    ///reates a new <see cref="ContactInformation"/> with the provided <see cref="id"/>, <see cref="email"/>, <see cref="phoneNumber"/>
    /// </summary>
    /// <param name="id">The persons ID</param>
    /// <param name="email">The persons firstname</param>
    /// <param name="phoneNumber">The persons lastname</param>
    ///<exception cref="ArgumentNullException"></exception>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public class ContactInformation
    {
        private int id;
        private string email;
        private string phoneNumber;

        public ContactInformation(int id, string email, string phoneNumber)
        {
            Id = id;
            Email = email;
            PhoneNumber = phoneNumber;
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
                    throw new ArgumentOutOfRangeException(nameof(Id), validationResult.errorMessage);
                }
                if(value != id)
                {
                    id = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets value of <see cref="email"/>
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        public string Email        {
            get => email;
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateEmail(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentNullException(nameof(Email), validationResult.errorMessage);
                }
                if(value != email)
                {
                    email = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets value of <see cref="phoneNumber"/>
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        public string PhoneNumber
        {
            get => phoneNumber;
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidatePhoneNumber(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentNullException(nameof(PhoneNumber), validationResult.errorMessage);
                }
                if(value != phoneNumber)
                {
                    phoneNumber = value;
                }
            }
        }

        /// <summary>
        /// Validates the ID of the Contact Information, must not be => 0
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Validates the email of the Contact Information, must not be NULL or WHITESPACE
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static (bool, string) ValidateEmail(string email)
        {
            if(string.IsNullOrWhiteSpace(email))
            {
                return (false, "Email'en er NULL, eller indeholder kun WHITESPACE");
            }
            if(!email.Contains("@"))
            {
                return (false, "Email skal indeholde et '@'.");
            }
            if(!email.Contains("."))
            {
                return (false, "Mail skal indeholde et domæne; f.eks '.com'");
            }
            else
            {
                return (true, String.Empty);
            }
        }

        /// <summary>
        /// Validates the phoneNumber of the Contact Information, must not be NULL or WHITESPACE
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public static (bool, string) ValidatePhoneNumber(string phone)
        {
            if(string.IsNullOrWhiteSpace(phone))
            {
                return (false, "Telefonnummeret er NULL, eller indeholder kun WHITESPACE.");
            }
            if(!phone.Any(c => char.IsNumber(c)))
            {
                return (false, "Telefonnummeret må kun indeholde tal, (0-9).");
            }
            if(phone.Length < 4)
            {
                return (false, "Telefonnummeret må ikke være < 4.");
            }
            if(phone.Length > 15)
            {
                return (false, "Telefonnummeret må ikke være > 15.");
            }
            else
            {
                return (true, String.Empty);
            }
        }
    }
}