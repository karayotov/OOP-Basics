using System;

namespace OpinionPoll
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());
            Family family = new Family();

            family.PrintOldersAlphabetical(family.AddMember(inputCount));
        }
    }
}