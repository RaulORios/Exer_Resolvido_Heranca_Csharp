using System;
using Exer_Resolvido_Heranca_Csharp.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Exer_Resolvido_Heranca_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value Per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmpolyee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }

            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS");
            foreach (Employee employee in list)
            {
                Console.WriteLine($"{employee.Name} - $ {employee.Payment().ToString("F2",CultureInfo.InvariantCulture)}");
            }

            Console.ReadKey();

        }
    }
}
