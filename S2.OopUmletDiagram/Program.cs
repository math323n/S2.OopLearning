using System;

namespace S2.OopUmletDiagram
{
    class Program
    {
        static void Main()
        {
            try
            {
                // Make person & contact information
                Person nikolaj = new Person(1, "Nikolaj", "Christoffersen", new DateTime(2000, 05, 05),
                new ContactInformation(1, "niko7185@edu.campusvejle.dk", "26259801"));

                // Make person & contact information
                Person mads = new Person(2, "Mads", "Mikkel Rasmussen", new DateTime(1983, 05, 19),
                new ContactInformation(2, "mara@aspit.dk", "98724979"));

                Console.WriteLine(nikolaj);
                Console.WriteLine();
                Console.WriteLine(mads);
            }
            catch(ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
        
        }
    }
}