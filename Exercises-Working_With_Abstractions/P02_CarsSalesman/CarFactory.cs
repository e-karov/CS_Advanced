using System.Collections.Generic;
using System.Linq;

namespace P02_CarsSalesman
{


    public class CarFactory
    {
        public Car Create(string[] parameters, List<Engine> engines)
        {
            string model = parameters[0];
            string engineModel = parameters[1];

            Engine engine = engines.FirstOrDefault(x => x.Model == engineModel);

            int weight = -1;

            if (parameters.Length == 3)
            {
                if (int.TryParse(parameters[2], out weight))
                {
                    return new Car(model, engine, weight);
                }

                else
                {
                    string color = parameters[2];

                    return new Car(model, engine, color);
                }
            }

            else if (parameters.Length == 4)
            {
                weight = int.Parse(parameters[2]);
                string color = parameters[3];

               return new Car(model, engine, weight, color);
            }

            else
            {
                return new Car(model, engine);
            }
        }
    }
}
