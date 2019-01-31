using System;
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

        public abstract double Area();
        
    }
}
