namespace P02_CarsSalesman                          // 100 / 100
{
    using System;


    public class Startup
    {
        static void Main()
        {
            CarFactory carFactory = new CarFactory();
            EngineFactory engineFactory = new EngineFactory();

            CarsSalesman carsSalesman = new CarsSalesman(carFactory, engineFactory);

            int enginesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < enginesCount; i++)
            {
                string[] parameters = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                carsSalesman.AddEngine(parameters);
            }

            int carCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carCount; i++)
            {
                string[] parameters = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                carsSalesman.AddCar(parameters);
            }

            Console.WriteLine();

            foreach (var car in carsSalesman.GetCars())
            {
                Console.WriteLine(car);
            }
        }
    }
}
