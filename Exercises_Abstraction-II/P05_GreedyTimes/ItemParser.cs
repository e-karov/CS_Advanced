namespace P05_GreedyTimes
{

    public class ItemParser
    {
        public string ParseItem(string name)
        {

                string item = string.Empty;

                if (name.Length == 3)
                {
                    item = "Cash";
                }
                else if (name.ToLower().EndsWith("gem"))
                {
                    item = "Gem";
                }
                else if (name.ToLower() == "gold")
                {
                    item = "Gold";
                }

            return item;
        }
    }
}
