using System;
using System.Collections.Generic;
using System.Text;

namespace S2.OopLearning.BL
{
    public class Account
    {
        private string accountNumber;
        private string departmentNumber;
        private decimal balance;

        public Account(string accountNumber)
        {

        }

        public string AccountNumber
        {
            get => accountNumber;
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateAccountNumber(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentException(nameof(AccountNumber), validationResult.errorMessage);
                }
                if(value != AccountNumber)
                {
                    accountNumber = value;
                }
            }
        }

        public string DepartmentNumber
        {
            get => departmentNumber;
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateDepartmentNumber(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentException(nameof(DepartmentNumber), validationResult.errorMessage);
                }
                if(value != AccountNumber)
                {
                    accountNumber = value;
                }
            }
        }

        public static (bool, string) ValidateAccountNumber(string account)
        {
            if(string.IsNullOrWhiteSpace(account))
            {
                return (false, "Konto nummeret er NULL, eller indeholder kun WHITESPACE");
            }
            if(account.Length != 10)
            {
                return (false, "Konto nummeret skal være 10 cifre langt.");
            }
            else
            {
                return (true, String.Empty);
            }
        }

        public decimal Balance
        {
            get => balance;
            set
            {
                if(value != balance)
                {
                    balance = value;
                }
            }
        }

        /// <summary>
        /// Validates the Department Number
        /// </summary>
        /// <param name="department"></param>
        /// <returns></returns>
        public static (bool, string) ValidateDepartmentNumber(string department)
        {
            if(string.IsNullOrWhiteSpace(department))
            {
                return (false, "Afdelings nummeret er NULL, eller indeholder kun WHITESPACE");
            }
            if(department.Length != 4)
            {
                return (false, "Afdelings nummeret skal være 4 cifre langt.");
            }
            if(department[0] == 0)
            {
                return (false, "Afdelings nummeret må ikke starte med 0.");
            }
            else
            {
                return (true, String.Empty);
            }
        }


    }
}