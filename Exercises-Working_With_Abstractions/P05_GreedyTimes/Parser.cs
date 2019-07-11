namespace P05_GreedyTimes
{

    public class Parser
    {

        public string ParseItem(string name)
        {
          string itemName = string.Empty;

                if (name.Length == 3)
                {
                    itemName = "cash";
                }

                else if (name.ToLower().EndsWith("gem"))
                {
                    itemName = "gem";
                }

                else if (name.ToLower() == "gold")
                {
                    itemName = "gold";
                }


                return (itemName);
            }
        }
    }
