using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Hospital
{
    public class Program
    {
        public static Dictionary<string, List<string>> doctors = new Dictionary<string, List<string>>();
        public static Dictionary<string, List<List<string>>> departments = new Dictionary<string, List<List<string>>>();

        public static void Main()
        {

            string command;

            ReadingDataFromConsole(command = Console.ReadLine());

            WritingDataToConsole(command = Console.ReadLine());
        }

        private static void WritingDataToConsole(string command)
        {
            while (command != "End")
            {
                ReadCommandForPrint(command);

                command = Console.ReadLine();
            }
        }

        private static void ReadCommandForPrint(string command)
        {
            string[] args = command.Split();

            
            if (args.Length == 1)
            {
                Console.WriteLine(AllPatientsInThisDepartments(args[0])); ;   
            }
            else if (args.Length == 2 && int.TryParse(args[1], out int roomNumber))
            {
                Console.WriteLine(AllPatientsInThisRoom(args[0], roomNumber));
            }
            else
            {
                Console.WriteLine(AllPatientsHealedFromThisDoctor(args[0], args[1]));
            }
            
        }

        private static string AllPatientsHealedFromThisDoctor(string firstName, string secondName)
        {
            string patientsHealedFromThisDoctor = string.Join("\n", doctors[firstName + secondName].OrderBy(x => x));
            return patientsHealedFromThisDoctor;
        }

        private static string AllPatientsInThisRoom(string department, int roomNumber)
        {
            string patientsInThisRoom = string.Join("\n", departments[department][roomNumber - 1].OrderBy(x => x));
            return patientsInThisRoom;
        }

        private static string AllPatientsInThisDepartments(string department)
        {
            string patients =  string.Join("\n", departments[department].Where(x => x.Count > 0).SelectMany(x => x));
            return patients;
        }

        private static void ReadingDataFromConsole(string command)
        {
            while (command != "Output")
            {
                AddData(command);

                command = Console.ReadLine();
            }
        }

        private static void AddData(string command)
        {
            string[] inputLine = command.Split();
            var departament = inputLine[0];
            var firstName = inputLine[1];
            var lastName = inputLine[2];
            var pacient = inputLine[3];
            var fullName = firstName + lastName;

            if (!doctors.ContainsKey(firstName + lastName))
            {
                doctors[fullName] = new List<string>();
            }
            if (!departments.ContainsKey(departament))
            {
                departments[departament] = new List<List<string>>();
                for (int stai = 0; stai < 20; stai++)
                {
                    departments[departament].Add(new List<string>());
                }
            }

            bool roomIsFull = departments[departament].SelectMany(x => x).Count() >= 60;
            if (roomIsFull == false)
            {
                int roomNumber = 0;
                doctors[fullName].Add(pacient);
                for (int st = 0; st < departments[departament].Count; st++)
                {
                    if (departments[departament][st].Count < 3)
                    {
                        roomNumber = st;
                        break;
                    }
                }
                departments[departament][roomNumber].Add(pacient);
            }
        }
    }
}
