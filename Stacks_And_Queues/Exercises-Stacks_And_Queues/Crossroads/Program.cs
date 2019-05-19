namespace Crossroads                    // 100 / 100
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            Queue<string> cars = new Queue<string>();
            int carCounter = 0;
            bool isSafe = true;

            while (input != "END")
            {
                if (input != "green")
                {
                    cars.Enqueue(input);
                }

                else if (input == "green")
                {
                    int currentGreenLight = greenLightDuration;

                    while (currentGreenLight > 0 && cars.Count > 0)
                    {
                        string nextCar = cars.Peek();

                        if (currentGreenLight - nextCar.Length >= 0 && cars.Count > 0)
                        {
                            currentGreenLight -= nextCar.Length;
                            cars.Dequeue();
                            carCounter++;
                        }

                        else
                        {
                            currentGreenLight += freeWindow;

                            if (currentGreenLight - nextCar.Length >= 0 && cars.Count > 0)
                            {
                                cars.Dequeue();
                                carCounter++;

                                break;
                            }

                            else
                            {
                                isSafe = false;
                                Console.WriteLine($"A crash happened!");
                                Console.WriteLine($"{nextCar} was hit at {nextCar[currentGreenLight]}.");

                                break;
                            }
                        }
                    }
                }

                if (!isSafe)
                {
                    break;
                }

                input = Console.ReadLine();
            }

            if (isSafe)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{carCounter} total cars passed the crossroads.");
            }
        }
    }
}
