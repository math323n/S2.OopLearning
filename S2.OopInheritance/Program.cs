using S2.OopInheritance.Inheritance;
using System;

namespace S2.OopInheritance
{
    class Program
    {
        static void Main()
        {
            try
            {
                DocumentFileInfo document = new DocumentFileInfo("autistfil", 12, new DateTime(2004, 12, 02));

                ImageFileInfo image = new ImageFileInfo(1920, 984, "autist", 23, new DateTime(1982,09,12));

                VideoFileInfo video = new VideoFileInfo(1920, 1080, "film om autisme", 100, 28, new DateTime(1971, 09, 12));

                Console.WriteLine(video);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}