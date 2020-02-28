using S2.OopUmletDiagram;
using System;
using Xunit;

namespace S2.CompositionTest
{
    public class CompositionTests
    {
        [Fact]
        public void Test()
        {
            Assert.True(true);
        }

        [Fact]
        public void TestPerson()
        {
           Person person = new Person(1, "N1kolaj", "Christoffersen", new DateTime(2000, 05, 05),
                new ContactInformation(1, "niko7185@edu.campusvejle.dk", "26259801"));

            Assert.Throws<ArgumentException>(
                () => Console.WriteLine(person)
                );

        }
    }
}
