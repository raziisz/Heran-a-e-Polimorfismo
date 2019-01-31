using MetodoAbstrato.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace MetodoAbstrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());
            List<Shape> listShapes = new List<Shape>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Black/Blue/Red: ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if(type == 'R' || type == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double heigth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    listShapes.Add(new Rectangle(color, width, heigth));
                } else if(type == 'C' || type == 'c'){
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    listShapes.Add(new Circle(color, radius));
                } else
                {
                    Console.WriteLine("Comando invalido");
                    i--;
                }

            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");

            foreach (Shape shape in listShapes)
            {
                Console.WriteLine("Color: "+shape.Color+"Area: "+shape.Area().ToString("F2",CultureInfo.InvariantCulture));
            }
        }
    }
}
