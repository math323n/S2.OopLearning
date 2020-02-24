using System;

namespace S2.OopLearning.BL
{
    class Program
    {
        static void Main()
        {
            Person person = new Person("Bjarne", "Jød", "1234567890");

            Console.WriteLine(person);
            Console.ReadLine();
        }
    }
}