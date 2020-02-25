using System;
using System.Collections.Generic;
using System.Text;

namespace S2.OopLearning.BL
{
    public class Field
    {
        private double width;
        private double length;
        private double area;
        private string crop;
        private double yield;

        public Field(double width, double length)
        {
            Width = width;
            Length = length;
        }

        public double Width
        {
            get => width;
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateWidth(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentOutOfRangeException(nameof(Width), validationResult.errorMessage);
                }
                if(value != width)
                {
                    width = value;
                }
            }
        }

        public double Length
        {
            get => length;
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateLength(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentOutOfRangeException(nameof(Length), validationResult.errorMessage);
                }
                if(value != length)
                {
                    length = value;
                }
            }
        }

        /// <summary>
        /// Validates the width
        /// </summary>
        public static (bool, string) ValidateWidth(double width)
        {
            if(width <= 0.0)
            {
                return (false, "Bredden må ikke være 0 eller under.");
            }
            else
            {
                return (true, String.Empty);
            }
        }

        public static (bool, string) ValidateLength(double length)
        {
            if(length <= 0.0)
            {
                return (false, "Længden må ikke være 0 eller under.");
            }
            else
            {
                return (true, string.Empty);
            }
        }







    }
}