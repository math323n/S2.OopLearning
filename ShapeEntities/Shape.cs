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
                (bool isValid, string errorMessage) validationResult = ValidateIntegerOverZero(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentOutOfRangeException(nameof(X), validationResult.errorMessage);
                }
                if(value != x)
                {
                    x = value;
                }
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
                (bool isValid, string errorMessage) validationResult = ValidateIntegerOverZero(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentOutOfRangeException(nameof(Y), validationResult.errorMessage);
                }
                if(value != y)
                {
                    y = value;
                }
            }
        }

        public static (bool, string) ValidateIntegerOverZero (int number)
        {
            if(number < 0)
            {
                return (false, "The number(s) must be greater than 0.");
            }
            else
            {
                return (true, string.Empty);
            }
        }

        public static (bool, string) ValidateDoubleOverZero(double number)
        {
            if(number < 0)
            {
                return (false, "The number(s) must be greater than 0.");
            }
            else
            {
                return (true, string.Empty);
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