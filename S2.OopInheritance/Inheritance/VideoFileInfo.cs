using S2.OopLearning.BL.Inheritance;
using System;
using System.Collections.Generic;
using System.Text;

namespace S2.OopInheritance.Inheritance
{
    class VideoFileInfo : ImageFileInfo
    {
        private int duration;

        public VideoFileInfo(int width, int height, string fileName, int duration, int fileSize, DateTime creationTime)
            : base(width, height, fileName, fileSize, creationTime)
        {
            Duration = duration;
        }

        public int Duration
        {
            get
            {
                return duration;
            }

            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateDuration(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentOutOfRangeException(nameof(Duration), validationResult.errorMessage);
                }
                if(value != duration)
                {
                    duration = value;
                }
            }
        }

        public (bool, string) ValidateDuration(int minutes)
        {
            if(minutes <= 0)
            {
                
                return (false, "Filmen må ikke være på 0 minutter eller derunder.");
            }
            else
            {
                return (true, String.Empty);
            }
        }

        public override string ToString()
        => $"Bredde: {Width}\nLængde: {Height}\nVideo: {fileName}\nMinutter: {duration}\nFilstørelse: {fileSize} MB\nOprettet: {creationTime.ToString("dd/MM/yyyy")}";
    }
}
