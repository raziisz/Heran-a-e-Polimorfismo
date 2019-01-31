﻿
namespace MetodoAbstrato.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle()
        {
        }

        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return 3.1416 * (Radius * Radius);
        }
    }
}
