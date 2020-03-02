using System;
using System.Collections.Generic;
using System.Text;

namespace S2.OopLearning.BL.Inheritance
{
    class CustomFileInfo
    {
        protected string fileName;
        protected int fileSize;
        protected DateTime creationTime;

        public CustomFileInfo(string fileName, int fileSize, DateTime creationTime)
        {
            FileName = fileName;
            FileSize = fileSize;
            CreationTime = creationTime;
        }

        public string FileName
        {
            get
            {
                return fileName;
            }

            set
            {
                fileName = value;
            }
        }

        public int FileSize
        {
            get
            {
                return fileSize;
            }

            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateFileSize(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentOutOfRangeException(nameof(FileSize), validationResult.errorMessage);
                }
                if(value != fileSize)
                {
                    fileSize = value;
                }
                
            }
        }

        public DateTime CreationTime
        {
            get
            {
                return creationTime;
            }

            set
            {
                creationTime = value;
            }
        }

        public (bool, string) ValidateFileSize(int fileSize)
        {
            if(fileSize > 45)
            {
                return (false, "Fil størelsen er over 45 MB. ");
            }
            if(fileSize <= 0)
            {
                return (false, "Fil størelsen er ugyldig.");
            }
            else
            {
                return (true, String.Empty);
            }
        }

        public override string ToString()
         => $"Filnavn: {fileName}\nFilstørelse: {fileSize}\nOprettet: {creationTime.ToString("dd/MM/yyyy")}";
    }
}