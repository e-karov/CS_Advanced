using System;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double FuelConsumption => base.FuelConsumption + 1.6;

        public override void Refuel(double fuel)
        {
            if (fuel <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }

            else if ((fuel * 0.95) + this.FuelQuantity <= this.TankCapacity)
            {
                this.FuelQuantity += fuel * 0.95;
            }

            else
            {
                Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
            }
        }

    }
}
