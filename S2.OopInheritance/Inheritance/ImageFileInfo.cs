using S2.OopLearning.BL.Inheritance;
using System;
using System.Collections.Generic;
using System.Text;

namespace S2.OopInheritance.Inheritance
{
    public class ImageFileInfo: CustomFileInfo
    {
        protected int width;
        protected int height;

        public ImageFileInfo(int width, int height, string fileName, int fileSize, DateTime creationTime)
            : base(fileName, fileSize, creationTime)
        {
            Width = width;
            Height = height;
        }

        public int Width
        {
            get
            {
                return width;
            }

            set
            {

                (bool isValid, string errorMessage) validationResult = ValidateImageWidth(value);
                if(validationResult.isValid)
                {
                    throw new ArgumentOutOfRangeException(nameof(Width), validationResult.errorMessage);
                }
                if(value != width)
                {
                    width = value;
                }
            }
        }

        public int Height
        {
            get
            {
                return height;
            }

            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateImageHeight(value);
                if(validationResult.isValid)
                {
                    throw new ArgumentOutOfRangeException(nameof(Height), validationResult.errorMessage);
                }
                if(value != height)
                {
                    height = value;
                }
            }
        }

        public (bool, string) ValidateImageWidth(int dimension)
        {
            if(dimension > 1920)
            {
                return (true, String.Empty);
            }
            else
            {
                return (false, "Forkert dimension");
            }
        }
        public (bool, string) ValidateImageHeight(int dimension)
        {
            if(dimension > 1080)
            {
                return (true, String.Empty);
            }
            else
            {
                return (false, "Forkert dimension");
            }
        }

        public override string ToString()
        => $"Bredde: {width}\nLængde: {height}\nFilnavn: {fileName}\nFilstørelse: {fileSize} MB\nOprettet: {creationTime.ToString("dd/MM/yyyy")}";
    }
}