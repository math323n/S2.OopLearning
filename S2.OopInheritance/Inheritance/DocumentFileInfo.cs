using S2.OopLearning.BL.Inheritance;
using System;
using System.Collections.Generic;
using System.Text;

namespace S2.OopInheritance.Inheritance
{
    class DocumentFileInfo: CustomFileInfo      
    {
        public DocumentFileInfo(string fileName, int fileSize, DateTime creationTime)
          : base(fileName, fileSize, creationTime)
        {

        }
    }
}