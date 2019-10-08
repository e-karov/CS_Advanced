namespace Shopping_Spree.Models
{
    public class Product
    {
        private string name;
        private decimal cost;

        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                Validator.ValidateText(value, $"{nameof(this.Name)}");

                this.name = value;
            }
        }

        public decimal Cost
        {
            get
            {
                return this.cost;
            }

            private set
            {
                Validator.ValidateMoney(value);

                this.cost = value;
            }
        }
    }
}
