using System;
using System.Collections.Generic;
using System.Linq;

namespace Truck_Tour                    // 100 / 100
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int[]> stations = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                stations.Enqueue(input);

            }

            int index = 0;

            while (true)
            {
                
                int currentPetrol = 0;

                foreach (var station in stations)
                {
                    currentPetrol += station[0] - station[1];

                    if (currentPetrol < 0)
                    {
                        index++;
                        stations.Enqueue(stations.Dequeue());
                        break;
                    }

                }

                if (currentPetrol >= 0)
                {
                    break;
                }
            }

            Console.WriteLine(index);
        }
    }
}
