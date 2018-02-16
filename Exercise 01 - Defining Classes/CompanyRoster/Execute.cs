using System;
using System.Linq;

class Execute
{
    static void Main(string[] args)
    {
        int employeeCounter = int.Parse(Console.ReadLine());

        for (int i = 0; i < employeeCounter; i++)
        {
            string[] refractoringArr = Console.ReadLine()
                  .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                  .ToArray();

            RefractorInputLine(refractoringArr);
        }
    }

    private static void RefractorInputLine(string[] refractoringArr)
    {
        string nameStr = refractoringArr[0];
        string salaryStr = refractoringArr[1];
        string positionStr = refractoringArr[2];
        string departmentStr = refractoringArr[3];
        string emailStr = "";
        string ageStr = "";

        if (refractoringArr.Length == 5)
        {
            emailStr = refractoringArr[4];
            ageStr = refractoringArr[5];
        }

        Employee employee = new Employee(nameStr, salaryStr, positionStr, emailStr, ageStr);

        if (Department.)
    }
}