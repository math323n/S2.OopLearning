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
                Console.WriteLine(document);
                

            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        
        }
    }
}
