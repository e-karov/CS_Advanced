using System;

namespace Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuantity;

        private double fuelConsumption;

        private double tankCapacity;

      
        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity
        {
            get { return this.fuelQuantity; }

            protected set
            {
                if (value > this.tankCapacity)
                {
                    this.fuelQuantity = 0;
                }

                else
                {
                    this.fuelQuantity = value;
                }
            }
        }

        public virtual double FuelConsumption
        {
            get { return this.fuelConsumption; }

            protected set
            {
                if (value > 0)
                {
                    this.fuelConsumption = value;
                }
            }
        }

        public double TankCapacity
        {
            get { return this.tankCapacity; }

            protected set
            {
                if (value > 0)
                {
                    this.tankCapacity = value;
                }
            }
        }

        public virtual string Drive(double distance)
        {
            double consumedFuel = distance * this.FuelConsumption;

            if (consumedFuel <= this.FuelQuantity)
            {
                this.FuelQuantity -= consumedFuel;

                return $"{this.GetType().Name} travelled {distance} km";
            }

            else
            {
                return $"{this.GetType().Name} needs refueling";
            }

        }


        public virtual void Refuel(double fuelAdded)
        {
            if (fuelAdded <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }

            else if (fuelAdded + fuelQuantity <= this.tankCapacity)
            {
                this.fuelQuantity += fuelAdded;
            }

            else
            {
                Console.WriteLine($"Cannot fit {fuelAdded} fuel in the tank");
            }

           
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.fuelQuantity:F2}";
        }
    }
}
