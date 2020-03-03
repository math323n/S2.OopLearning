using System;
using System.Collections.Generic;
using System.Text;

namespace S2.OopLearning.BL.Inheritance
{
    public abstract class CustomFileInfo
    {
        protected string fileName;
        protected int fileSize;
        protected DateTime creationTime;

        protected CustomFileInfo(string fileName, int fileSize, DateTime creationTime)
        {
            FileName = fileName;
            FileSize = fileSize;
            CreationTime = creationTime;
        }

        public virtual string FileName
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

        public virtual int FileSize
        {
            get
            {
                return fileSize;
            }

            set
            {
                bool isValid = IsSizeTooLarge();
                if(isValid)
                {
                    throw new ArgumentOutOfRangeException(nameof(FileSize), $"FileSize must not exceed 45 MB.");
                }
                if(value != fileSize)
                {
                    fileSize = value;
                }
                
            }
        }

        public virtual DateTime CreationTime
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

        public virtual bool IsSizeTooLarge()
        {
            return fileSize > 45 ? true : false;
        }

        public override string ToString()
         => $"Filnavn: {fileName}\nFilstørelse: {fileSize}\nOprettet: {creationTime.ToString("dd/MM/yyyy")}";
    }
}