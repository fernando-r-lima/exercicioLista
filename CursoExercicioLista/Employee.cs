using System;
using System.Collections.Generic;
using System.Text;

namespace CursoExercicioLista
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

                
        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percent)
        {
            Salary += (Salary * (percent / 100)); 
        }

    }


}
