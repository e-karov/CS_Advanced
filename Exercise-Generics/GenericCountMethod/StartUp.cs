using System;

namespace GenericCountMethod                            // 100 / 100
{
    public class Program
    {
        public static void Main()
        {
            int itemsCount = int.Parse(Console.ReadLine());

            Box<double> box = new Box<double>();

            for (int i = 0; i < itemsCount; i++)
            {
                double input = double.Parse(Console.ReadLine());
                box.Add(input);
            }

            double numToCompare =double.Parse(Console.ReadLine());

            int result = box.CompareItems(numToCompare);

            Console.WriteLine(result);
        }
    }
}
