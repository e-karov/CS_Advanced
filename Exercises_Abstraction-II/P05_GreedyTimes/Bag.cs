namespace P05_GreedyTimes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class Bag
    {
        private long capacity;

        private Dictionary<string, Dictionary<string, long>> items;

        public Bag(long capacity)
        {
            this.capacity = capacity;
            this.Items = new Dictionary<string,  Dictionary<string, long>>();
        }

        public Dictionary<string, Dictionary<string, long>> Items { get; set; }

        public long Capacity => this.Capacity;

        public void PrintBagContent()
        {
            var filteredItems = this.Items.Where(i => i.Value.Values.Sum() > 0);

            foreach (var item in this.Items)
            {
                long amount = item.Value.Values.Sum();

                Console.WriteLine($"<{item.Key}> ${amount}");

                var orderedItems = item.Value
                    .OrderByDescending(y => y.Key)
                    .ThenBy(y => y.Value);

                foreach (var item2 in orderedItems)
                {
                    Console.WriteLine($"##{item2.Key} - {item2.Value}");
                }
            }
        }
    }
}
