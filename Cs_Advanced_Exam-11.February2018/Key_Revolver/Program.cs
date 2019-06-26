using System;
using System.Collections.Generic;
using System.Linq;

namespace Key_Revolver                  // 100 / 100
{
    public class StartUp
    {
        public static void Main()
        {
            int bulletsPrice = int.Parse(Console.ReadLine());
            int barrelCapacity = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> bulletStack = new Stack<int>(bullets);

            int[] locks = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> locksQueue = new Queue<int>(locks);

            int value = int.Parse(Console.ReadLine());

            int bulletCounter = 0;

            while (bulletStack.Count > 0 && locksQueue.Count > 0)
            {
                    int currentLock = locksQueue.Peek();
                    int currentBullet = bulletStack.Pop();

                    if (currentBullet > currentLock)
                    {
                        Console.WriteLine("Ping!");
                    }

                    else
                    {
                        locksQueue.Dequeue();
                        Console.WriteLine("Bang!");
                    }


                bulletCounter++;

                if (bulletCounter == barrelCapacity && bulletStack.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    bulletCounter = 0;
                }
            }

            if (locksQueue.Count == 0)
            {
                int moneyEarned = value - (bulletsPrice * (bullets.Length - bulletStack.Count));

                Console.WriteLine($"{bulletStack.Count} bullets left. Earned ${moneyEarned}");
            }

            else if (bulletStack.Count == 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
            }
        }
    }
}
