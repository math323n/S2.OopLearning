using System;

namespace S2.OopLearning.BL
{
    class Program
    {
        static void Main()
        {
            // Create person
            try
            {
                Person person = new Person("Nikolaj", "Christofferesen", "2806007890", Gender.Autist);
                Console.WriteLine($"Navn {person.FirstName} {person.LastName}\n" +
                    $"CPR nr: {person.Cpr}\n" +
                    $"Fødselsdato: {person.Birthday.ToString("dd/MM/yyyy")}\n" +
                    $"Køn: {person.Gender}");
            }
         
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();
            // Create account
            try
            {
                Account account = new Account("YOB420696X", "Z420", 7890);
                Console.WriteLine($"Kontonummer: {account.AccountNumber}\n" +
                    $"Afdelingsnummer: {account.DepartmentNumber}\n" +
                    $"Balance: {account.Balance}");
            }

            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();
            // Create crop
            try
            {
                Field field = new Field(205.5, 106.6, "wheat");
                Console.WriteLine($"Width: {field.Width}\n" +
                    $"Længde: {field.Length}\n" +
                    $"Afgrød: {field.Crop}\n" +
                    $"Område: {field.Area}\n" +
                    $"Udbytte: {field.Yield}");
            }

            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}