﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeEntities
{
    public class Circle : Shape
    {
        protected double radius;

        public Circle(int x, int y, double radius)
            : base(x, y)
        {
            Radius = radius;
        }

        public virtual double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                radius = value;
            }
        }


        
    }
}