using System;

namespace S2.OopLearning.BL
{
    class Program
    {
        static void Main()
        {
            Person person = new Person("Bjarne", "Jød", "a234567890");

            Console.WriteLine(person);
            Console.ReadLine();
        }
    }
}