using System;
using System.Collections.Generic;
using System.Text;

namespace S2.OopUmletDiagram
{
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

        public string Email        {
            get => email;
            set
            {
                if(value != email)
                {
                    email = value;
                }
            }
        }

        public string PhoneNumber
        {
            get => phoneNumber;
            set
            {
                if(value != phoneNumber)
                {
                    phoneNumber = value;
                }
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

        public static (bool, string) ValidateEmail(string email)
        {
            if(string.IsNullOrWhiteSpace(email))
            {
                return (false, "Email'en er NULL, eller indeholder kun WHITESPACE");
            }
            else
            {
                return (true, String.Empty);
            }
        }

        public static (bool, string) ValidatePhoneNumber(string phone)
        {
            if(string.IsNullOrWhiteSpace(phone))
            {
                return (false, "Telefon nummeret er NULL, eller indeholder kun WHITESPACE");
            }
            else
            {
                return (true, String.Empty);
            }
        }
    }
}