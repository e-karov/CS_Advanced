using System;                                                  // 100 / 100

namespace Vehicles
{
    public class StartUp
    {
        static void Main()
        {
            string[] carInfo = Console.ReadLine().Split();
            string[] truckInfo = Console.ReadLine().Split();
            string[] busInfo = Console.ReadLine().Split();

            int count = int.Parse(Console.ReadLine());

            double carFuel = double.Parse(carInfo[1]);
            double carConsumption = double.Parse(carInfo[2]);
            double carTank = double.Parse(carInfo[3]);
            double truckFuel = double.Parse(truckInfo[1]);
            double truckConsumption = double.Parse(truckInfo[2]);
            double truckTank = double.Parse(truckInfo[3]);
            double busFuel = double.Parse(busInfo[1]);
            double busConsumption = double.Parse(busInfo[2]);
            double busTank = double.Parse(busInfo[3]);

            Car car = new Car(carFuel, carConsumption, carTank);
            Truck truck = new Truck(truckFuel, truckConsumption, truckTank);
            Bus bus = new Bus(busFuel, busConsumption, busTank);

            for (int i = 0; i < count; i++)
            {
                string[] commandLine = Console.ReadLine().Split();

                string command = commandLine[0];
                string type = commandLine[1];

                switch (type)
                {
                    case "Car":

                        if (command == "Drive")
                        {
                            double distance = double.Parse(commandLine[2]);

                            Console.WriteLine(car.Drive(distance));
                        }

                        else if (command == "Refuel")
                        {
                            double fuel = double.Parse(commandLine[2]);

                            car.Refuel(fuel);
                        }

                        break;

                    case "Truck":

                        if (command == "Drive")
                        {
                            double distance = double.Parse(commandLine[2]);

                            Console.WriteLine(truck.Drive(distance));
                        }

                        else if (command == "Refuel")
                        {
                            double fuel = double.Parse(commandLine[2]);

                            truck.Refuel(fuel);
                        }

                        break;

                    case "Bus":

                        if (command == "Drive")
                        {
                            double distance = double.Parse(commandLine[2]);

                            Console.WriteLine(bus.Drive(distance));
                        }

                        else if (command == "Refuel")
                        {
                            double fuel = double.Parse(commandLine[2]);

                            bus.Refuel(fuel);
                        }

                        else if (command == "DriveEmpty")
                        {
                            double distance = double.Parse(commandLine[2]);
                            Console.WriteLine(bus.DriveEmpty(distance));
                        }
                        break;
                }

            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }


    }

}
