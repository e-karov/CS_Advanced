namespace P05_GreedyTimes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class Bag
    {
        public Bag(int capacity)
        {
            this.Capacity = capacity;
            this.Gems = new List<Gem>();
            this.Cash = new List<Cash>();
            this.Items = new List<Item>();
            this.Gold = new Gold();
            
        }

        public int Capacity { get; private set; }

        public List<Item>  Items { get; private set; }

        public List<Cash> Cash { get; private set; }

        public Gold Gold { get; private set; }

        public List<Gem> Gems { get; private set; }

        public long TotalAmount => this.Items.Select(i => i.Amount).Sum();
            
        public long TotalGemsAmount =>
            this.Gems.Select(x => x.Amount).Sum();

        public long TotalCashAmount =>
            this.Cash.Select(c => c.Amount).Sum();

               
        public void AddGem(string name, long quantity)
        {
            if ( this.Gems.FirstOrDefault(g => g.Name == name) == null)
            {
                Gem gemToAdd = new Gem(name, quantity);
                this.Gems.Add(gemToAdd);
            }

            else
            {
                Gem gemToAdd = this.Gems.FirstOrDefault(g => g.Name == name);

                gemToAdd.Amount += quantity;
            }
        }

        public void AddCash(string name, long quantity)
        {
            if (this.Cash.FirstOrDefault(g => g.Currency == name) == null)
            {
                Cash cashToAdd = new Cash(name, quantity);

                this.Cash.Add(cashToAdd);
            }

            else
            {
                Cash cashToAdd = this.Cash.FirstOrDefault(g => g.Currency == name);

                cashToAdd.Amount += quantity;
            }
        }

        public void AddItem(string name, long quantity)
        {
            if (this.Items.Select(x => x.Name).Contains(name))
            {
                this.Items.FirstOrDefault(x => x.Name == name).Amount += quantity;
            }

            else
            {
                Item item = new Item(name, quantity);
                this.Items.Add(item);
            }
        }

     
        public void PrintResult()
        {            
            foreach (var item in this.Items.OrderByDescending(i => i.Amount))
            {
                Console.WriteLine($"<{item.Name}> ${item.Amount}");

                foreach (var type in item.OrderByDescending(y => y.Name).ThenBy(y => y.Amount))
                {
                    Console.WriteLine($"##{type.Name} - {type.Amount}");
                }
            }
        }
    }
}
