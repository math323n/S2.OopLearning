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
                DocumentFileInfo document = new DocumentFileInfo("filnavn", 45, new DateTime(69, 01, 01));
                Console.WriteLine(document.FileSize);

            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        
        }
    }
}
