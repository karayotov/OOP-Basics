using System;
using System.Collections.Generic;
using System.Linq;

//SOURCE: https://github.com/RAstardzhiev/Software-University-SoftUni/tree/master/C%23%20OOP%20Basics/Defining%20Classes%20-%20Exercise/06.%20Company%20Roster

class Execute
{
    static void Main(string[] args)
    {
        Stack<Employee> employees = GetEmployees();
        PrintEmployeesWithHighetSalary(employees);
    }

    private static void PrintEmployeesWithHighetSalary(Stack<Employee> employees)
    {
        if (employees.Count == 0)
        {
            return;
        }

        var highestAverageSalaryDepartment = employees.GroupBy(e => e.Department)
            .OrderByDescending(g => g.Select(e => e.Salary).Sum())
            .First();

        Console.WriteLine($"Highest Average Salary: {highestAverageSalaryDepartment.Key}");
        Console.WriteLine(string.Join(Environment.NewLine, highestAverageSalaryDepartment
            .OrderByDescending(e => e.Salary)
            .Select(e => $"{e.Name} {e.Salary} {e.Email} {e.Age}")));
    }
    private static Stack<Employee> GetEmployees()
    {
        Stack<Employee> employees = new Stack<Employee>();
        int numberOfEmployees = int.Parse(Console.ReadLine());

        while (employees.Count < numberOfEmployees)
        {
            string email = "n/a";
            int age = -1;
            string[] personData = Console.ReadLine().Split();

            if (personData.Length > 4)
            {
                int parsed;
                var isDigit = int.TryParse(personData[4], out parsed);

                if (isDigit)
                {
                    age = parsed;
                }
                else
                {
                    email = personData[4];
                }

                if (personData.Length > 5)
                {
                    if (isDigit)
                    {
                        email = personData[5];
                    }
                    else
                    {
                        age = int.Parse(personData[5]);
                    }
                }
            }

            employees.Push(new Employee(
                personData[0],
                decimal.Parse(personData[1]),
                personData[2],
                personData[3],
                email,
                age
            ));
        }
        return employees;
    }
}