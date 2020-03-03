using System;

namespace ShapeEntities
{
    abstract public class Shape
    {
        protected int x;
        protected int y;

        protected Shape(int x, int y)
        {
            X = x;
            Y = y;
        }

        public virtual int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public virtual int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public abstract double CalculateArea();

        public abstract double CalculateCircumference();
        

        public override string ToString()
        {
            return $"X: {x}\nY: {y}";
        }
        
    }
}