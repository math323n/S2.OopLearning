using System;

namespace ShapeEntities
{
    public class Shape
    {
        private int x;
        private int y;

        public Shape()
        {

        }

        protected int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        protected int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }
    }
}