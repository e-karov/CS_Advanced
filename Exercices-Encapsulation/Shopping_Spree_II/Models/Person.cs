using Shopping_Spree.Models;
using System;
using System.Collections.Generic;

namespace Shopping_Spree
{
    public class Person
    {
        private string name;

        private decimal money;

        private List<Product> products;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;

            this.products = new List<Product>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                Validator.ValidateText(value, $"{nameof (this.Name)}");

                this.name = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }

            private set
            {
                Validator.ValidateMoney(value);

                this.money = value;
            }
        }

        public IReadOnlyList<Product> Products => this.products.AsReadOnly();


        public void BuyProduct(Product product)
        {
            if (this.money - product.Cost >= 0)
            {
                this.products.Add(product);

                this.money -= product.Cost;

                Console.WriteLine($"{this.Name} bought {product.Name}");
            }

            else
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
        }
    }
}
