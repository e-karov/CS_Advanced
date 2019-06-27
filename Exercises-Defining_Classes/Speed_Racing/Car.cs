using System;
using System.Collections.Generic;
using System.Text;

namespace Speed_Racing
{
    public class Car
    {
        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumtionPerKm { get; set; }

        public double TraveledDistance = 0;

        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumtionPerKm = fuelConsumption;
        }

        public void Drive(double distance)
        {
            double usedFuel = FuelConsumtionPerKm * distance;

            if (usedFuel <= FuelAmount)
            {
                FuelAmount -= usedFuel;
                TraveledDistance += distance;
            }

            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
