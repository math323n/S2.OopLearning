using System;
using System.Collections.Generic;
using System.Text;

namespace S2.OopUmletDiagram
{
    public class Address
    {
        private int id;
        private string streetName;
        private string streetNumber;
        private string zip;
        private string city;
        private string country;
        
       

        public Address(int id, string streetName, string streetNumber, string zip, string city, string country)
        {
            Id = id;
            StreetName = streetName;
            StreetNumber = streetNumber;
            Zip = zip;
            City = city;
            Country = country;
        }

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

        public string StreetName    
        {
            get => streetName;
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateString(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentException(nameof(StreetName), validationResult.errorMessage);
                }
                if(value != streetName)
                {
                    streetName = value;
                }
            }
        }

        public string StreetNumber 
        {
            get => streetNumber;
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateString(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentException(nameof(StreetNumber), validationResult.errorMessage);
                }
                if(value != streetNumber)
                {
                    streetNumber = value;
                }
            }
        }

        public string Zip
        {
            get => zip;
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateString(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentException(nameof(Zip), validationResult.errorMessage);
                }
                if(value != zip)
                {
                    zip = value;
                }
            }
        }

        public string City
        {
            get => city;
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateString(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentException(nameof(City), validationResult.errorMessage);
                }
                if(value != city)
                {
                    city = value;
                }
            }
        }

        public string Country
        {
            get => country;
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateString(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentException(nameof(Country), validationResult.errorMessage);
                }
                if(value != country)
                {
                    country = value;
                }
            }
        }

        public static (bool, string) ValidateString(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                return (false, "Gadenavnet er NULL, eller indeholder kun WHITESPACE");
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

    }
}
