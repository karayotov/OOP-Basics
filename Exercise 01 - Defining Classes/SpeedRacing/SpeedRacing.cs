using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    class SpeedRacing
    {
        static void Main(string[] args)
        {
            
            int carsCount = int.Parse(Console.ReadLine());

            List<Car> carList = AddCars(carsCount);

            RaceTime(carList);
            PrintCars(carList);

        }

        private static void PrintCars(List<Car> carList)
        {
            carList.ForEach(a => a.PrintCar(a));
        }

        private static void RaceTime(List<Car> carList)
        {
            string driveData;

            while ((driveData = Console.ReadLine()) != "End")
            {

                string[] data = driveData.Split();
                string model = data[1];
                int distance = int.Parse(data[2]);

                carList.Where(a => a.Model == model).ToList().ForEach(a => a.HitTheRoad(distance));
            }
        }

        private static List<Car> AddCars(int carsCount)
        {
            List<Car> carList = new List<Car>();

            for (int i = 0; i < carsCount; i++)
            {

                string[] carData = Console.ReadLine().Split();
                Car car = new Car(carData[0], int.Parse(carData[1]), double.Parse(carData[2]));
                carList.Add(car);
            }

            return carList;
        }
    }
}