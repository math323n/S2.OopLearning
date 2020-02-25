using System;

namespace S2.OopLearning.BL
{
    class Program
    {
        static void Main()
        {
            Person person = new Person("Nikolaj", "Christofferesen", "2412047890", Gender.Autist);
            Console.WriteLine(person.Gender);
            Console.WriteLine(person);
            Console.ReadLine();
        }
    }
}