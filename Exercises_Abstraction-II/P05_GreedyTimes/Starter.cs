namespace P05_GreedyTimes
{
    using System;


    public class Starter
    {
        public void Run()
        {
            long bagCapacity = long.Parse(Console.ReadLine());
            string[] safe = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Bag bag = new Bag(bagCapacity);
            ItemCollector itemCollector = new ItemCollector();
            itemCollector.CollectItems(bag, safe);
            bag.PrintBagContent();
        }
    }
}
