using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_RawData                                   // 100 / 100
{
   
    public class RawData
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            CarCatalogue carCatalogue = new CarCatalogue();

            for (int i = 0; i < lines; i++)
            {
                string[] parameters = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                CarFactory carFactory = new CarFactory();
                Car car = carFactory.CreateCar(parameters);

                carCatalogue.Add(car);
               
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                List<string> fragile = carCatalogue.GetCars()
                    .Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(y => y.Pressure < 1))
                    .Select(x => x.Model)
                    .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, fragile));
            }
            else
            {
                List<string> flamable = carCatalogue.GetCars()
                    .Where(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250)
                    .Select(x => x.Model)
                    .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, flamable));
            }
        }
    }
}
