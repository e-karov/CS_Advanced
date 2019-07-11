namespace NeedForSpeed
{

    public class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;

        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }


        public virtual double FuelConsumption => DefaultFuelConsumption;

        public double Fuel { get; protected set; }

        public int HorsePower { get; protected set; }


        public void Drive(double kilometers)
        {
            double fuelUsed = kilometers * this.FuelConsumption;

            if (this.Fuel >= fuelUsed)
            {
                this.Fuel -= fuelUsed;
            }

            else
            {
                System.Console.WriteLine("Not enough fuel for this trip!");
            }
        }
    }
}
