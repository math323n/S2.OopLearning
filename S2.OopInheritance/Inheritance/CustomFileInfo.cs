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
                fileSize = value;
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
                return (false, "Filen må ikke være på mere end 45 mb!");
            }
            if(fileSize == 0)
            {
                return (false, "Filens størrelse er ugyldig!");
            }
            else
            {
                return (true, String.Empty);
            }
        }


    }
}
