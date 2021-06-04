using System;
using System.Collections.Generic;
using System.Globalization;

namespace CursoExercicioLista
{
    class Program
    {

        //IMCOMPLETO:   Exercício pdf AULA 78
        //              terminar depois de aprender proporties e implementar
        //              o condicionamento do id no get.
        //              depois, ainda implementar a função de aumento de salário

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

            Console.WriteLine("Updated list of employess:");
            foreach (Employee obj in employeesList)
            {
                Console.WriteLine($"{obj.Id}, {obj.Name}, {obj.Salary.ToString("F2", CultureInfo.InvariantCulture)}");
            }

        }
    }
}
