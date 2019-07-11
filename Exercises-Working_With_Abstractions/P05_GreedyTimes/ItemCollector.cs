using System.Linq;

namespace P05_GreedyTimes
{
    public class ItemCollector
    {

        public void CollectItems(Bag bag, string[] safeContent)
        {
            Parser parser = new Parser();
            
            for (int i = 0; i < safeContent.Length; i+=2)
            {
                string inputName = safeContent[i];
                long quantity = long.Parse(safeContent[i + 1]);

                string name = parser.ParseItem(inputName);

                
                if (bag.Capacity >= (bag.TotalAmount + quantity))
                {
                   

                    switch (name)
                    {
                        case "gem":

                            if (bag.TotalGemsAmount + quantity <= bag.Gold.Amount)
                            {
                                bag.AddGem(name, quantity);
                                bag.AddItem(name, quantity);
                            }
                            break;

                        case "cash":

                            if (bag.TotalCashAmount + quantity <= bag.TotalGemsAmount)
                            {
                                bag.AddCash(name, quantity);
                                bag.AddItem(name, quantity);
                            }
                            break;

                         case "gold":

                            bag.Gold.AddAmount(quantity);
                            bag.AddItem(name, quantity);
                            break;
                    }

                }

                else
                {
                    continue;
                }
            }
        }
    }
}
