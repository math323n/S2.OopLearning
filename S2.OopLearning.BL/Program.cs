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
            Console.ReadLine();
        }
    }
}