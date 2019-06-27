using System;
using System.Collections.Generic;
using System.Linq;

namespace Speed_Racing                              // 100 / 100
{
    public class StartUp
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < count; i++)
            {
                string[] carData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carData[0];
                double fuelAmount = double.Parse(carData[1]);
                double fuelConsumption = double.Parse(carData[2]);

                Car car = new Car(model, fuelAmount, fuelConsumption);

                cars.Add(car);
            }

            string inputLine = "";

            while ((inputLine = Console.ReadLine()) != "End")
            {
                string[] driveLine = inputLine.Split();
                string model = driveLine[1];
                double distance = double.Parse(driveLine[2]);

                Car carToDrive = cars
                    .FirstOrDefault(c => c.Model == model);

                carToDrive.Drive(distance);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TraveledDistance}");
            }
        }
    }
}
