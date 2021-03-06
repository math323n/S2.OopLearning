﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace S2.OopUmletDiagram
{
    /// <summary>
    /// reates a new <see cref="Address"/> with the provided <see cref="id"/>, <see cref="streetName"/>, <see cref="zip"/> <see cref="city"/>, <see cref="country"
    ///  </summary>
    /// <param name="id">The address' id</param>
    /// <param name="stretName">The address' streetName</param>
    /// <param name="streetNumber">The address' streetNumber</param>
    /// <param name="zip">The address' zip</param>
    /// <param name="city">The address' city</param>
    /// <param name="country">The address' country</param>
    ///<exception cref="ArgumentException"></exception>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public class Address
    {
        private int id;
        private string streetName;
        private int streetNumber;
        private string zip;
        private string city;
        private string country;
        private List<Person> persons;

        public Address(int id, string streetName, int streetNumber, string zip, string city, string country, List<Person> persons)
        {
            Id = id;
            StreetName = streetName;
            StreetNumber = streetNumber;
            Zip = zip;
            City = city;
            Country = country;
            Persons = persons;
        }

        /// <summary>
        /// Gets or sets value of <see cref="persons"/>
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public List<Person> Persons
        {
            get => persons;
            set
            {
                if(value != persons)
                {
                    persons = value;
                }
            }
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
        /// Gets or sets value of <see cref="streetName"/>
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
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

        /// <summary>
        /// Gets or sets value of <see cref="streetNumber"/>
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public int StreetNumber
        {
            get => streetNumber;
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateId(value);
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

        /// <summary>
        /// Gets or sets value of <see cref="zip"/>
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public string Zip
        {
            get => zip;
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateZip(value);
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

        /// <summary>
        /// Gets or sets value of <see cref="city"/>
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public string City
        {
            get => city;
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateCity(value);
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

        /// <summary>
        /// Gets or sets value of <see cref="country"/>
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public string Country
        {
            get => country;
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateCountry(value);
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

        /// <summary>
        /// Method for gettign the amount of residents
        /// </summary>
        public int GetNumberOfPeople()
        {
            return Persons.Count();
        }
        /// <summary>
        /// Prints information
        /// </summary>
        public void PrintinfoAboutAddress()
        {
            Console.WriteLine($"Gadenavn: {streetName}\nHusnummer: {streetNumber}\nZip: {zip}\n" +
                $"By: {city}\nLand: {country}");
        }

        /// <summary>
        /// Validates the string
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Validates the country string
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static (bool, string) ValidateCountry(string country)
        {
            if(string.IsNullOrWhiteSpace(country))
            {
                return (false, "Country er NULL, eller indeholder kun WHITESPACE");
            }
            if(country.Any(c => char.IsDigit(c)))
            {
                return (false, "Country må ikke indeholde andet end bogstaver og mellemrum!");
            }
            if(!country.Any(c => char.IsLetter(c)))
            {
                return (false, "Country skal indeholde mindst 1 bogstav!");
            }
            else
            {
                return (true, String.Empty);
            }
        }

        /// <summary>
        /// Validates the city string
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static (bool, string) ValidateCity(string city)
        {
            if(string.IsNullOrWhiteSpace(city))
            {
                return (false, "City er NULL, eller indeholder kun WHITESPACE");
            }
            if(city.Any(c => char.IsDigit(c)))
            {
                return (false, "City må ikke indeholde andet end bogstaver og mellemrum!");
            }
            if(!city.Any(c => char.IsLetter(c)))
            {
                return (false, "City skal indeholde mindst 1 bogstav!");
            }
            else
            {
                return (true, String.Empty);
            }
        }

        /// <summary>
        ///  Validates the ID
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
        ///  Validates the Zip
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static (bool, string) ValidateZip(string zip)
        {
            if(zip.Length <= 2)
            {
                return (false, "Zip må ikke være <= 2");
            }
            else
            {
                return (true, String.Empty);
            }
        }
    }
}