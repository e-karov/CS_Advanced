using ShopingSpree.Exceptions;
using System;

namespace ShopingSpree
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

        public string  Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.NullOrEmptyNameExcepzion);
                }
                this.name = value;
            }
        }

        public decimal Cost
        {
            get => this.cost;

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.NegativeMoneyException);
                }
                this.cost = value;
            }
        }

    }
}
