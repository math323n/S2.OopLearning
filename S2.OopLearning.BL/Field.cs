using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace S2.OopLearning.BL
{
    public class Field
    {
        private double width;
        private double length;
        private string crop;
        private double area;
        private double yield;

        static string[] legitimateCrops = { "potato", "wheat", "oat", "carrot" };

        public Field(double width, double length, string crop)
        {
            Width = width;
            Length = length;
            Crop = crop;
            //Yield = yield;
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
                    area = (length * width);
                    return area;
                }
            }
        }

        public string Crop
        {
            get => crop;
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateCrop(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentException(nameof(Crop), validationResult.errorMessage);
                }
                if(value != crop)
                {
                    crop = value;
                }
            }
        }

        public double Yield
        {
            get
            {
                // Wheat
                if(crop == legitimateCrops[0])
                {
                    yield = (area * 20);
                    return yield;
                }
                // Potato
                 if(crop == legitimateCrops[1])
                {
                    yield = (area * 40);
                    return yield;
                }
                // Oat
                 if(crop == legitimateCrops[2])
                {
                    yield = (area * 15);
                    return yield;
                }
                // Carrots
                 if(crop == legitimateCrops[3])
                {
                    yield = (area * 66.66);
                    return yield;
                }
                // Nothing
                else
                {
                    yield = 0;
                    return yield;
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
        public static (bool, string) ValidateCrop(string crop)
        {

            if(string.IsNullOrWhiteSpace(crop))
            {
                return (false, "Afgrøden er NULL, eller indeholder kun WHITESPACE");
            }
           if(legitimateCrops.Contains(crop.ToLower()))
            {
                return (true, String.Empty);
            }
            else
            {
                return (false, "Afgrøden er ugyldig.");
            }
        }
    }
}