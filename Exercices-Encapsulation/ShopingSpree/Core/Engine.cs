namespace ShopingSpree.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Engine
    {
        public static  void Run()
        {
            string[] personsInput = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries);

            List<Person> people = new List<Person>();

            for (int i = 0; i < personsInput.Length; i++)
            {
                string[] personInfo = personsInput[i]
                    .Split('=', StringSplitOptions.RemoveEmptyEntries);

                string name = personInfo[0];
                decimal money = decimal.Parse(personInfo[1]);

                try
                {
                    Person person = new Person(name, money);

                    people.Add(person);
                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            string[] productsInput = Console.ReadLine()
               .Split(';', StringSplitOptions.RemoveEmptyEntries);

            List<Product> products = new List<Product>();

            for (int i = 0; i < productsInput.Length; i++)
            {
                string[] productInfo = productsInput[i]
                    .Split('=', StringSplitOptions.RemoveEmptyEntries);

                string productName = productInfo[0];
                decimal cost = decimal.Parse(productInfo[1]);

                try
                {
                    Product product = new Product(productName, cost);

                    products.Add(product);
                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            string[] command = Console.ReadLine().Split();

            while (command[0] != "END")
            {
                string name = command[0];
                string currentProductName = command[1];

                Person buyingPerson = people.FirstOrDefault(p => p.Name == name);
                Product currentProduct = products.FirstOrDefault(p => p.Name == currentProductName);

                if (buyingPerson != null && currentProduct != null)
                {
                    if (buyingPerson.BuyProduct(currentProduct))
                    {
                        Console.WriteLine($"{buyingPerson.Name} bought {currentProduct.Name}");
                    }
                }

                command = Console.ReadLine().Split();
            }

            foreach (var person in people)
            {
                if (person.Products.Count() == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }

                else
                {
                    Console.WriteLine($"{person.Name} - " +
                        $"{String.Join(", ", person.Products.Select(p => p.Name))}");
                }
            }
        }
    }
}
