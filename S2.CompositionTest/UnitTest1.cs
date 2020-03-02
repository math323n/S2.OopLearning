using S2.OopUmletDiagram;
using S2.OopInheritance;
using System;
using Xunit;
using S2.OopInheritance.Inheritance;

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
            Person person = new Person(1, "Nikolaj", "Christoffersen", new DateTime(2000, 05, 05),
                 new ContactInformation(1, "niko7185@edu.campusvejle.dk", "26259801"));

            Assert.Throws<ArgumentOutOfRangeException>(
                () => new Person(1, "Nikolaj", "Christoffersen", new DateTime(2000, 05, 05),
                new ContactInformation(1, "niko7185@edu.campusvejle.dk", "26259801"))
                );
        }

        [Fact]
        public void TestTheDocumentSizeTooLarge()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => new DocumentFileInfo("dokument", 47, new DateTime(2004, 12, 02)));
        }

        [Fact]
        public void TestTheImageSizeTooLarge()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => new ImageFileInfo(1920, 1080, "Billede", 55, new DateTime(2004, 12, 02)));
        }

        [Fact]
        public void TestTheVideoSizeTooLarge()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => new VideoFileInfo(1920, 1080, "Film om autister", 199, 45, new DateTime(2004, 12, 02)));
        }


    }
}