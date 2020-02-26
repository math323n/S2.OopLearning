using System;

namespace S2.OopUmletDiagram
{
    class Program
    {
        static void Main()
        {
            // Make persons
            Person person = new Person(1, "Nikolaj", "Christoffersen", new DateTime(2000, 05, 05));
            Console.WriteLine(person);
        }
    }
}