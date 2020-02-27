using System;
using System.Collections.Generic;

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

                // Make person & contact information
                Person dyl = new Person(3, "Dyl", "Pickle", new DateTime(1985, 12, 03),
                new ContactInformation(2, "dylPickles@mail.dk", "956524979"));

                // Addresse 1
                Address address_germany = new Address(1, "Gadevej", 2, "53", "Vejle", "Tyskland", new List<Person>() { mads, dyl});

                // Address 2
                Address address_denmark = new Address(2, "Gadestræde", 25, "12", "Odense", "Danmark", new List<Person>() { nikolaj });

                address_denmark.PrintinfoAboutAddress();
                Console.WriteLine();
                address_denmark.GetNumberOfPeople();


                address_germany.PrintinfoAboutAddress();
                address_germany.GetNumberOfPeople();
                Console.WriteLine();
                Console.WriteLine(mads);
                Console.WriteLine(dyl);
                Console.WriteLine(nikolaj);
            }
            catch(ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
        
        }
    }
}