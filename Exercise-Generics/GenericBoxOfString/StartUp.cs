using System;
using System.Linq;

namespace GenericBoxOfString                    
{
    public class StartUp
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            Box<int> box = new Box<int>();

            for (int i = 0; i < count; i++)
            {
                int num = int.Parse(Console.ReadLine());
                box.Add(num);
            }

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            box.Swap(indexes[0], indexes[1]);

            Console.WriteLine(box);
        }
    }
}
