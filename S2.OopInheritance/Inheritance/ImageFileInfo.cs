using S2.OopLearning.BL.Inheritance;
using System;
using System.Collections.Generic;
using System.Text;

namespace S2.OopInheritance.Inheritance
{
    class ImageFileInfo : CustomFileInfo
    {
        private int width;
        private int height;

        public ImageFileInfo(int width, int height, string fileName, int fileSize, DateTime creationTime)
            : base(fileName, fileSize, creationTime)
        {
            Width = width;
            Height = height;
        }

        protected int Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value;
            }
        }

        protected int Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }


       
    }
}
