namespace P05_GreedyTimes
{
    public class Gold
    {
        public long Amount { get; set; }

        public void AddAmount(long quantity)
        {
            this.Amount += quantity;
        }


        public override string ToString()
        {
            return $"##Gold - {this.Amount}";
        }
    }
}
