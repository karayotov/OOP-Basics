using System;
using System.Collections.Generic;
                  // задачата е преписана от GitHub: RAstardzhiev
class Program
{
    static void Main(string[] args)
    {
        Queue<Animal> animals = GetAnimals();
        Console.WriteLine(string.Join(Environment.NewLine, animals));
    }

    private static Queue<Animal> GetAnimals()
    {
        Queue<Animal> animals = new Queue<Animal>();
        string kind = Console.ReadLine();

        while (kind != "Beast!")
        {
            string[] animalDetails = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            string name = animalDetails[0];
            int age = int.Parse(animalDetails[1]);
            string gender = animalDetails[2];

            try
            {
                Animal animal = AnimalFactory.GetAnimal(kind, name, age, gender);
                animals.Enqueue(animal);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

            kind = Console.ReadLine();
        }
        return animals;
    }
}