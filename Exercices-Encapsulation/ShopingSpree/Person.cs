namespace ShopingSpree
{
    using System;
    using System.Collections.Generic;
    using ShopingSpree.Exceptions;

    public class Person
    {
        private string name;

        private decimal money;

        private List<Product> products;

        public Person (string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.products = new List<Product>();
        }


        public string Name
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

        public decimal Money
        {
            get => this.money;

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.NegativeMoneyException);
                }
                this.money = value;
            }
        }

        public IReadOnlyList<Product> Products
        {
            get => this.products.AsReadOnly();
        }


        public bool BuyProduct(Product product)
        {
            bool isBought = false;

            if (this.money - product.Cost >= 0)
            {
                this.products.Add(product);
                this.money -= product.Cost;

                isBought = true;
            }
            else
            {
                Console.WriteLine(String.Format(ExceptionMessages.CannotAffordAProductException, this.name, product.Name) );
            }

            return isBought;
        }
    }
}
