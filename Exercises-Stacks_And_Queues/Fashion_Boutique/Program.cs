using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique                      // 100 / 100
{
    class Program
    {
        static void Main()
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(clothes.Reverse());
            int rackCounter = 1;
            int currentRack = rackCapacity;

            for (int i = 0; i < clothes.Length; i++)
            {
                int currentValue = stack.Peek();
                
                if (currentRack - currentValue > 0)
                {
                    currentRack -= stack.Pop();
                }

                else if (currentRack - currentValue == 0)
                {
                    stack.Pop();
                    currentRack -= currentValue;
                }

                else
                {
                    rackCounter++;
                    currentRack = rackCapacity - stack.Pop(); 
                    
                }
            }

            Console.WriteLine(rackCounter);
        }
    }
}
