using System;

namespace Problem03_Mankind
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputline = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            string firstName = inputline[0];
            string lastName = inputline[1];
            string facultyNumber = inputline[2];

            Student student;
            try
            {
                student = new Student(firstName, lastName, facultyNumber);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            inputline = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            firstName = inputline[0];
            lastName = inputline[1];

            double weekSalary = double.Parse(inputline[2]);
            double hoursPerDay = double.Parse(inputline[3]);
            Worker worker;

            try
            {
                worker = new Worker(firstName, lastName, weekSalary, hoursPerDay);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            Console.WriteLine(student);
            Console.WriteLine(worker);
        }
    }
}