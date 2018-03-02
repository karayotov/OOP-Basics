using System;
using System.Linq;

// задачата е преписана от GitHub: RAstardzhiev

namespace Porblem05_MordorsCruelPlan
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            player.Eat(Console.ReadLine()
                .Split()
                .Where(fn => fn != string.Empty)
                .Select(fn => FoodFactory.GetFood(fn)));

            Console.WriteLine(player);
        }
    }
}
