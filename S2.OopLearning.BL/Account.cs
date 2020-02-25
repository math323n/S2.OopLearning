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

        /// <summary>
        ///  reates a new <see cref="Person"/> with the provided <see cref="firstName"/>, <see cref="lastName"/>, <see cref="cpr"/>
        ///  </summary>
        /// <param name="accountNumber">The account number</param>
        /// <param name="departmentNumber">The department number</param>
        /// <param name="balance">The balance</param>
        ///<exception cref="ArgumentException"></exception>
        public Account(string accountNumber, string departmentNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            DepartmentNumber = departmentNumber;
            Balance = balance;
        }

        /// <summary>
        /// Gets or sets value of <see cref="accountNumber"/>
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
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
        /// <summary>
        /// Gets or sets value of <see cref="departmentNumber"/>
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
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
                if(value != DepartmentNumber)
                {
                    departmentNumber = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets value of <see cref="balance"/>
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public decimal Balance
        {
            get => balance;
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateBalance(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentException(nameof(Balance), validationResult.errorMessage);
                }
                if(value != Balance)
                {
                    balance = value;
                }
            }
        }

        /// <summary>
        /// Validates the account number
        /// </summary>
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

        /// <summary>
        /// Validates the balance
        /// </summary>
        public static (bool, string) ValidateBalance(decimal amount)
        {
           
            if(amount < 0)
            {
                return (false, "Beløbet må ikke være negativt.");
            }
            else
            {
                return (true, String.Empty);
            }
        }



    }
}