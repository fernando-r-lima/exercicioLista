using System;
using System.Collections.Generic;
using System.Globalization;

namespace CursoExercicioLista
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Employee> employeesList = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int numberEmployees = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberEmployees; i++)
            {
                Console.WriteLine($"Employee #{i}:");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                employeesList.Add(new Employee(id, name, salary));
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idAumento = int.Parse(Console.ReadLine());

            Employee employee = employeesList.Find(x => x.Id == idAumento);
            if (employee == null)
            {
                Console.WriteLine("This id does not exist!");
            }
            else
            {
                Console.Write("Enter the percentage: ");
                double percentAumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employee.IncreaseSalary(percentAumento);
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employess:");
            foreach (Employee obj in employeesList)
            {
                Console.WriteLine($"{obj.Id}, {obj.Name}, {obj.Salary.ToString("F2", CultureInfo.InvariantCulture)}");
            }

        }
    }
}
