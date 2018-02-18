using System;
using System.Collections.Generic;
using System.Text;

public class Employee
{
    private string name, position, email, department;
    private decimal salary;
    private int age;

    public Employee(string nameStr, decimal salaryStr, string positionStr, string departmentStr)
    {
        this.name = nameStr;
        this.salary = salaryStr;
        this.position = positionStr;
        this.department = departmentStr;
    }

    public Employee(string name, decimal salary, string position, string department, string email, int age)
        :this(name, salary, position, department)
    {
        this.email = email;
        this.age = age;
    }

    public string Name
    {
        get { return this.name; }
    }
    public decimal Salary
    {
        get { return this.salary; }
    }
    public string Department
    {
        get { return this.department; }
    }
    public string Posiotion
    {
        get { return this.position; }
    }
    public string Email
    {
        get { return this.email; }
    }
    public int Age
    {
        get { return this.age; }
    }
}
//Name  salary  position    department  email         age
//Pesho 120.00  Dev         Development pesho@abv.bg  28
//Gosho 0.20    Freeloader  Nowhere                   18