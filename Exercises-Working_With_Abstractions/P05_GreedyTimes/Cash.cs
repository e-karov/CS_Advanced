namespace P05_GreedyTimes
{
    public class Cash
    {
        public Cash(string currency, long amount)
        {
            this.Currency = currency;
            this.Amount = amount;
        }

        public string Currency { get; set; }

        public long Amount { get; set; }

       
        public override string ToString()
        {
            return $"##{this.Currency} - {this.Amount}";
        }
    }
}
