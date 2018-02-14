using System;

namespace DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string start = Console.ReadLine();
            string end = Console.ReadLine();

            DateModifierStore dateModifierStore = new DateModifierStore(start, end);

            dateModifierStore.PrintDays();
        }
    }
}