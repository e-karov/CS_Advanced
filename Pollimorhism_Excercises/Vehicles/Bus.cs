namespace Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double FuelConsumption { get => base.FuelConsumption + 1.4; }

        public string DriveEmpty (double distance)
        {
            double consumedFuel = (this.FuelConsumption - 1.4) * distance;

            if (consumedFuel <= this.FuelQuantity)
            {
                this.FuelQuantity -= consumedFuel;

                return $"Bus travelled {distance} km";
            }

            else
            {
                return "Bus needs refueling";
            }
        }
    }
}
