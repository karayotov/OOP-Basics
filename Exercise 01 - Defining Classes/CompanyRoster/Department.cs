using System.Collections.Generic;
using System.Linq;

public class Department
{
    private List<Employee> employees;
    public string departmentName;
    public int average;

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

    public Department (Employee employee, string name):this(name)
    {

        Employees.Add(employee);

    }

    public decimal AverageSalaryInThisDepartment(List<Employee> employees)
    {
        decimal Average = employees.Average(a => a.Salary);
        return Average;
    }
}