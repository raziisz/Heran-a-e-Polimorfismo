using ExercicioResolvido1.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioResolvido1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.WriteLine();
                Console.Write("Outsourced (y/n)? ");
                char op = char.Parse(Console.ReadLine());

                if (op == 'y' || op == 'Y')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Additional charge: ");
                    double addCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Employee employee = new OutsourceEmployee(name, hours, valuePerHour, addCharge);
                    employee.Payment();

                    employees.Add(employee);
                    
                } else if(op == 'n' || op == 'N'){
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Employee employee = new Employee(name, hours, valuePerHour);
                    employee.Payment();
                    employees.Add(employee);
                } else{

                    Console.WriteLine("Comando invalido");
                    i--;
                }

            }

            Console.WriteLine("PAYMENTS");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.Name+ " - $"+employee.ValuePerHour);
            }
        }
    }
}
