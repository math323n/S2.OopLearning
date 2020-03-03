using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeEntities
{
    public class Circle : Shape
    {
        protected double radius;

        public Circle(int x, int y, double radius)
            : base(x, y)
        {
            Radius = radius;
        }

        public virtual double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                radius = value;
            }
        }

      

        public override double CalculateArea()
        {
            double area;
            area = Math.PI * radius * radius;
            return area;
        }

        public override double CalculateCircumference()
        {
            double circumference;
            circumference = 2 * radius * Math.PI;
            return circumference;
        }

        public override string ToString()
        {
            return $"X: {x}\nY: {y}\nRadius: {radius}\n" +
                $"Area: {CalculateArea()}\nCircumference: {CalculateCircumference()}";
        }

    }
}
