using System;
using System.Collections.Generic;

namespace Auto_Repair_Service               // 100 / 100
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            Queue<string> carsWaiting = new Queue<string>(input);

            Stack<string> servedCars = new Stack<string>();

            string[] commandLine = Console.ReadLine().Split("-");
            string command = commandLine[0];

            while (command != "End")
            {
                switch (command)
                {
                    case "Service":
                        if (carsWaiting.Count > 0)
                        {
                            string currentCar = carsWaiting.Dequeue();

                            Console.WriteLine($"Vehicle {currentCar} got served.");
                            servedCars.Push(currentCar);
                        }
                        break;

                    case "CarInfo":

                        string carModel = commandLine[1];

                        if (carsWaiting.Contains(carModel))
                        {
                            Console.WriteLine($"Still waiting for service.");
                        }

                        else
                        {
                            Console.WriteLine("Served.");
                        }
                        break;

                    case "History":
                        string[] carsServed = servedCars.ToArray();

                        Console.WriteLine(String.Join(", ", carsServed));
                        break;
                }


                commandLine = Console.ReadLine().Split("-");
                command = commandLine[0];
            }

            if (carsWaiting.Count > 0 )
            {
                Console.Write($"Vehicles for service: ");
                Console.WriteLine(String.Join(", ", carsWaiting));
            }

            Console.Write($"Served vehicles: ");
            Console.WriteLine(String.Join(", ", servedCars));
        }
    }
}
