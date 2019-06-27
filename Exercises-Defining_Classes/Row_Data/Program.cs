using System;
using System.Collections.Generic;
using System.Linq;

namespace Row_Data                          // 100 / 100
{
    public class StartUp
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();


            for (int i = 0; i < count; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = carInfo[0];
                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];
                double tire1Pressure = double.Parse(carInfo[5]);
                int tireAge1 = int.Parse(carInfo[6]);
                double tire2Pressure = double.Parse(carInfo[7]);
                int tireAge2 = int.Parse(carInfo[8]);
                double tire3Pressure = double.Parse(carInfo[9]);
                int tireAge3 = int.Parse(carInfo[10]);
                double tire4Pressure = double.Parse(carInfo[11]);
                int tireAge4 = int.Parse(carInfo[12]);

                Engine engine = new Engine(engineSpeed, enginePower);

                Tire[] tires = new Tire[4];

                tires[0] = new Tire(tireAge1, tire1Pressure);
                tires[1] = new Tire(tireAge2, tire2Pressure);
                tires[2] = new Tire(tireAge3, tire3Pressure);
                tires[3] = new Tire(tireAge4, tire4Pressure);


                Cargo cargo = new Cargo(cargoType, cargoWeight);

                Car car = new Car(model, engine, tires, cargo);

                cars.Add(car);
            }

            string criteria = Console.ReadLine();

            if (criteria == "fragile")
            {
                cars
                    .FindAll(c => c.Cargo.Type == "fragile")
                    .Where(c => c.Tires.Any(t => t.Pressure < 1))
                    .ToList()
                    .ForEach(c => Console.WriteLine(c.Model));
            }

            else if (criteria == "flamable")
            {
                cars
                    .FindAll(c => c.Cargo.Type == "flamable")
                    .Where(c => c.Engine.Power > 250)
                    .ToList()
                    .ForEach(c => Console.WriteLine(c.Model));
            }
        }
    }
}
