﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MetodoAbstrato.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape()
        {
        }

        protected Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
        
    }
}
