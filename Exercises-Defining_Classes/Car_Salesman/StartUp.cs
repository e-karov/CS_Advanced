using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Car_Salesman                                    // 100 / 100  
{
    public class StartUp
    {
        public static void Main()
        {
            int enginesCount = int.Parse(Console.ReadLine());

            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();

            for (int i = 0; i < enginesCount; i++)
            {
                string inputLine = Console.ReadLine();
                Match engineMatch = Regex.Match(inputLine, @"(?<model>\w+-.\d+) (?<power>\d+) ?(?<displacement>\d+)? ?(?<efficiency>.+)?");

                string model = engineMatch.Groups["model"].Value;
                string power = engineMatch.Groups["power"].Value;

                Engine engine = new Engine(model, power);

                if (engineMatch.Groups["displacement"].Value != String.Empty)
                {
                    engine.Displacement = engineMatch.Groups["displacement"].Value;
                }

                if (engineMatch.Groups["efficiency"].Value != String.Empty)
                {
                   
                    engine.Efficiency = engineMatch.Groups["efficiency"].Value;
                }

                engines.Add(model, engine);
            }

            int carsCount = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < carsCount; i++)
            {
                string[] carsInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carsInput[0];
                string engineModel = carsInput[1];
                int weight = 0;
                string color = string.Empty;

                Car car = new Car(model, engines[engineModel]);

                if (carsInput.Length == 3)
                {
                    if( int.TryParse(carsInput[2], out weight))
                    {
                        car.Weight = weight.ToString();
                    }

                    else
                    {
                        car.Color = carsInput[2];
                    }

                    
                }

                if (carsInput.Length > 3)
                {
                    car.Weight = carsInput[2];

                    car.Color = carsInput[3];
                }

                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
