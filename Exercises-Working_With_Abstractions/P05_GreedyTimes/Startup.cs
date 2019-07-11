namespace P05_GreedyTimes
{
    using System;
    using System.Linq;


    public class Startup
    {
        public static void Main()
        {
            int bagCapacity = int.Parse(Console.ReadLine());
            string[] safeContent = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Bag bag = new Bag(bagCapacity);

            ItemCollector itemCollector = new ItemCollector();

            itemCollector.CollectItems(bag, safeContent);
            bag.PrintResult();


           
        }

      
    }
}