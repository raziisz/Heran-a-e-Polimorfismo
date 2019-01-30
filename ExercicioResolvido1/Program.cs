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
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                char op = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (op == 'y' || op == 'Y')
                {
                   
                    Console.Write("Additional charge: ");
                    double addCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Employee employee = new OutsourceEmployee(name, hours, valuePerHour, addCharge);
                    

                    employees.Add(employee);
                    
                } else if(op == 'n' || op == 'N'){

                    Employee employee = new Employee(name, hours, valuePerHour);
                    
                    employees.Add(employee);
                } else{

                    Console.WriteLine("Comando invalido");
                    i--;
                }

            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS");
            double pagamaneto = 0.0;
            foreach (Employee employee in employees)
            {
                pagamaneto = employee.Payment();
                Console.WriteLine(employee.Name+ " - $"+pagamaneto.ToString("F2",CultureInfo.InvariantCulture));
            }
        }
    }
}
