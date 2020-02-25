using System;
using System.Collections.Generic;
using System.Text;

namespace S2.OopLearning.BL
{
    public class Field
    {
        private double width;
        private double length;
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
                (bool isValid, string errorMessage) validationResult = ValidateNumber(value);
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
                (bool isValid, string errorMessage) validationResult = ValidateNumber(value);
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

        public double Area
        {
            get
            {
                (bool isValid, string errorMessage) validationResult = ValidateNumber(length);
                if(!validationResult.isValid)
                {
                    throw new InvalidOperationException(validationResult.errorMessage);
                }
                validationResult = ValidateNumber(width);
                if(!validationResult.isValid)
                {
                    throw new InvalidOperationException(validationResult.errorMessage);
                }
                else
                {
                    return (length * width);
                }
            }
        }

        public string Crop
        {
            get => crop;
            set
            {
                if(value != crop)
                {
                    crop = value;
                }
            }
        }

        /// <summary>
        /// Validates a number for IS 0 or UNDER 0
        /// </summary>
        public static (bool, string) ValidateNumber(double number)
        {
            if(number <= 0.0)
            {
                return (false, "Tallet må ikke være 0 eller under.");
            }
            else
            {
                return (true, String.Empty);
            }
        }
       
        /// <summary>
        /// Validates the area (width + length)
        /// </summary>
       






    }
}