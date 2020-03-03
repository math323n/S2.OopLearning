using System;
using ShapeEntities;

namespace ShapeManualTest
{
    class Program
    {
        static void Main()
        {
            try
            {
                Circle circle = new Circle(67, 6, 123);
                Console.WriteLine(circle);
            }
           catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}