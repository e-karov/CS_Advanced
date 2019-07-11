namespace P05_GreedyTimes
{
    using System.Collections.Generic;
    using System.Linq;

    public class ItemCollector
    {

        public void CollectItems(Bag bag, string[] safe)
        {
            ItemParser parser = new ItemParser();
            bag.Items = new Dictionary<string, Dictionary<string, long>>();


            for (int i = 0; i < safe.Length; i += 2)
            {
                string name = safe[i];
                long quantity = long.Parse(safe[i + 1]);

                string item = parser.ParseItem(name);

               
                if (bag.Capacity < bag.Items.Select(x => x.Value.Values.Sum()).Sum() + quantity)
                {
                    continue;
                }

                switch (item)
                {
                    case "Gem":
                        if (!bag.Items.ContainsKey(item))
                        {
                            if (bag.Items.ContainsKey("Gold"))
                            {
                                if (quantity > bag.Items["Gold"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bag.Items[item].Values.Sum() + quantity > bag.Items["Gold"].Values.Sum())
                        {
                            continue;
                        }
                        break;

                    case "Cash":
                        if (!bag.Items.ContainsKey(item))
                        {
                            if (bag.Items.ContainsKey("Gem"))
                            {
                                if (quantity > bag.Items["Gem"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }

                        else if (bag.Items[item].Values.Sum() + quantity > bag.Items["Gem"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                }

                if (!bag.Items.ContainsKey(item))
                {
                    bag.Items[item] = new Dictionary<string, long>();
                }

                if (!bag.Items[item].ContainsKey(name))
                {
                    bag.Items[item][name] = 0;
                }

                bag.Items[item][name] += quantity;

            }
        }

    }
}

