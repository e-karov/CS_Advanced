using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food             // 100 / 100
{
    class Program
    {
        static void Main()
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(orders);
            int maxOrder = queue.Max();

            for (int i = 0; i < orders.Length; i++)
            {
                int currentOrder = queue.Peek();

                if (foodQuantity - currentOrder >= 0)
                {
                    foodQuantity -= queue.Dequeue();
                }

                else
                {
                    int count = queue.Count;

                    Console.WriteLine(maxOrder);
                    Console.Write("Orders left: ");

                    Console.WriteLine(String.Join(' ', queue));
                    return;
                }
            }

            Console.WriteLine(maxOrder);
            Console.WriteLine("Orders complete");
        }
    }
}
