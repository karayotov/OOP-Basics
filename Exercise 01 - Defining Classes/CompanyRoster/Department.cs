using System.Collections.Generic;
using System.Linq;

public class Department
{
    private List<Employee> employees;
    private string departmentName;
    private int average;

    public int Average
    {
        get { return average; }
        set { average = value; }
    }

    public string DepartmentName
    {
        get { return departmentName; }
        set { departmentName = value; }
    }

    public List<Employee> Employees
    {
        get { return employees; }
        set { employees = value; }
    }

    public Department(string name)
    {
        DepartmentName = name;
    }

    public List<Employee> FillingDepartment (Employee employee, int count)
    {
        
        Employees.Add(employee);

        return Employees;
    }

    public decimal FindAverageSalary(List<Employee> employees)
    {
        decimal Average = employees.Average(a => a.Salary);
        return Average;
    }
}