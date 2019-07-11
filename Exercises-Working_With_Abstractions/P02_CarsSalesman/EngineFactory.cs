﻿namespace P02_CarsSalesman
{

    public class EngineFactory
    {
        public Engine Create(string[] parameters)
        {
            string model = parameters[0];
            int power = int.Parse(parameters[1]);

            int displacement = -1;

            if (parameters.Length == 3)
            {
                if (int.TryParse(parameters[2], out displacement))
                {
                    return new Engine(model, power, displacement);
                }
                else
                {
                    string efficiency = parameters[2];
                    return new Engine(model, power, efficiency);
                }
            }

            else if (parameters.Length == 4)
            {
                displacement = int.Parse(parameters[2]);
                string efficiency = parameters[3];

                return new Engine(model, power, displacement, efficiency);
            }

            else
            {
                return new Engine(model, power);
            }
        }
    }
}