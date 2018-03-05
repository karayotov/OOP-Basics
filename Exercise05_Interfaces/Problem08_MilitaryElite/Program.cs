using Problem08_MilitaryElite.Classes;
using Problem08_MilitaryElite.Classes.Soldiers;
using Problem08_MilitaryElite.Classes.Soldiers.Privates.SpecialisedSoldiers;
using Problem08_MilitaryElite.Interfaces;
using Problem08_MilitaryElite.Interfaces.ISoldierFolder;
using Problem08_MilitaryElite.Interfaces.ISoldierFolder.IPrivateFolder;
using Problem08_MilitaryElite.Interfaces.ISoldierFolder.IPrivateFolder.ISpecialisedSoldiersFolder;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem08_MilitaryElite
{
    class Program
    {
        public static Army armyOfSoldiers = new Army();

        static void Main(string[] args)
        {
            string inputLine;

            while ((inputLine = Console.ReadLine()) != "End")
            {
                string[] dataArr = inputLine.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string soldierType = dataArr[0];

                switch (soldierType)
                {
                    case "Private":

                        IPrivate privateSoldier = new Private(dataArr[1], dataArr[2], dataArr[3], double.Parse(dataArr[4]));

                        armyOfSoldiers.Soldiers.Add(privateSoldier);
                        //GetSoldier(soldierType, privateSoldier);

                        break;
                    case "LeutenantGeneral":
                        ILeutenantGeneral leutenantSoldier = new LeutenantGeneral(dataArr[1], dataArr[2], dataArr[3], double.Parse(dataArr[4]));

                        leutenantSoldier = GetPrivates(dataArr, leutenantSoldier);

                        armyOfSoldiers.Soldiers.Add(leutenantSoldier);


                        break;
                    case "Engineer":

                        IEngineer engineer = new Engineer(dataArr[1], dataArr[2], dataArr[3], double.Parse(dataArr[4]), dataArr[5]);

                        engineer = GetRepairs(dataArr, engineer);

                        armyOfSoldiers.Soldiers.Add(engineer);

                        break;

                    case "Commando":

                        IComando comando = new Comando(dataArr[1], dataArr[2], dataArr[3], double.Parse(dataArr[4]), dataArr[5]);

                        comando = GetComando(dataArr, comando);

                        armyOfSoldiers.Soldiers.Add(comando);

                        break;
                    case "Spy":

                        ISoldier spySoldier = new Spy(dataArr[1], dataArr[2], dataArr[3], dataArr[4]);

                        armyOfSoldiers.Soldiers.Add(spySoldier);

                        break;
                }
            }
        }

        private static IComando GetComando(string[] dataArr, IComando comando)
        {
            for (int i = 7; i < dataArr.Length; i += 2)
            {
                IMission mission = new Mission(dataArr[i - 1], dataArr[i]);
                comando.Missions.Add(mission);
            }

            return comando;
        }

        private static IEngineer GetRepairs(string[] dataArr, IEngineer engineer)
        {
            for (int i = 7; i < dataArr.Length; i += 2)
            {
                string part = dataArr[i - 1];
                string hoursWorket = dataArr[i];
                IRepair repair = new Repair(part, int.Parse(hoursWorket));
                engineer.AddRepair(repair);
            }

            return engineer;
        }

        private static ILeutenantGeneral GetPrivates(string[] dataArr, ILeutenantGeneral leutenantSoldier)
        {
            string soldierId;
            for (int i = 5; i < dataArr.Length; i++)
            {
                soldierId = dataArr[i];
                string soldierType = dataArr[0];

                foreach (var soldier in armyOfSoldiers.Soldiers)
                {
                    if (soldier.Id == soldierId)
                    {
                        leutenantSoldier.Privates.Add(soldier);
                    }
                }
            }

            return leutenantSoldier;
        }
    }
}

//•	Private: “Private<id> <firstName> <lastName> <salary>”
//•	LeutenantGeneral: “LeutenantGeneral<id> <firstName> <lastName> <salary> <private1Id> <private2Id> … <privateNId>”
//  where privateXId will always be an Id of a private already received through the input.
//•	Engineer: “Engineer<id> <firstName> <lastName> <salary> <corps> <repair1Part> <repair1Hours> … <repairNPart> <repairNHours>” 
//  where repairXPart is the name of a repaired part and repairXHours the hours it took to repair it(the two parameters will always come paired). 
//•	Commando: “Commando<id> <firstName> <lastName> <salary> <corps> <mission1CodeName>  <mission1state> … <missionNCodeName> <missionNstate>”
//  a missions code name, description and state will always come together.
//•	Spy: “Spy<id> <firstName> <lastName> <codeNumber>”
