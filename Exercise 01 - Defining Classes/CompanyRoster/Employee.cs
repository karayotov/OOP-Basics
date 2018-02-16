using System;
using System.Collections.Generic;
using System.Text;

public class Employee
{
    private string name, position, email;
    private decimal salary;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public decimal Salary
    {
        get { return salary; }
        set { salary = value; }
    }
    public string Posiotion
    {
        get { return position; }
        set { position = value; }
    }
    public string Email
    {
        get { return email; }
        set { email = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public Employee(string nameStr, string salaryStr, string positionStr, string emailStr, string ageStr)
    {
        Name = nameStr;
        Salary = decimal.Parse(salaryStr);
        Posiotion = positionStr;
        Email = EmailHere(emailStr);
        Age = AgeHere(ageStr);
    }

    public string EmailHere(string email)
    {
        if (email == "")
        {
            return "n/a";
        }
        else
        {
            return email;
        }
    }

    public int AgeHere(string age)
    {
        if (age == "") return -1;
        else return int.Parse(age);
    }
}
//Name  salary  position    department  email         age
//Pesho 120.00  Dev         Development pesho@abv.bg  28
//Gosho 0.20    Freeloader  Nowhere                   18