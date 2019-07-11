namespace P01_RawData
{
    public class CarFactory
    {

        public Car CreateCar(string[] parameters)
        {
            string model = parameters[0];
            int engineSpeed = int.Parse(parameters[1]);
            int enginePower = int.Parse(parameters[2]);
            int cargoWeight = int.Parse(parameters[3]);
            string cargoType = parameters[4];
            
            Engine engine = new Engine(engineSpeed, enginePower);
            Cargo cargo = new Cargo(cargoWeight, cargoType);
            Tire[] tires = new Tire[4];

            int tireIndex = 0;

            for (int i = 5; i <= 12; i+=2)
            {
                double pressure = double.Parse(parameters[i]);
                int age = int.Parse(parameters[i + 1]);

                Tire tire = new Tire(pressure, age);

                tires[tireIndex] = tire;

                tireIndex++;
            }

            Car car = new Car(model, engine, cargo, tires);

            return car;
        }
    }
}
