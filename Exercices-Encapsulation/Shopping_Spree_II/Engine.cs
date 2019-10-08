using Shopping_Spree.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping_Spree
{
    public class Engine
    {
        public void Run()
        {
            string[] personsInput = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries);
            string[] productsInput = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries);

            List<Person> people = new List<Person>();

            for (int i = 0; i < personsInput.Length; i++)
            {
                string[] currentPerson = personsInput[i]
                    .Split('=', StringSplitOptions.RemoveEmptyEntries);

                string name = currentPerson[0];
                decimal money = decimal.Parse(currentPerson[1]);

                try
                {
                    Person person = new Person(name, money);

                    people.Add(person);
                }

                catch (ArgumentException ae)
                {

                    Console.WriteLine(ae.Message);
                    return;
                }
            }

            List<Product> products = new List<Product>();

            for (int i = 0; i < productsInput.Length; i++)
            {
                string[] currentProduct = productsInput[i]
                    .Split('=', StringSplitOptions.RemoveEmptyEntries);

                string name = currentProduct[0];
                decimal cost = decimal.Parse(currentProduct[1]);

                try
                {
                    Product product = new Product(name, cost);

                    products.Add(product);
                }

                catch (ArgumentException ae)
                {

                    Console.WriteLine(ae.Message);
                    return;
                }
            }

            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "END")
            {
                string personName = command[0];
                string productName = command[1];

                Person person = people
                    .FirstOrDefault(p => p.Name == personName);


                Product product = products
                    .FirstOrDefault(x => x.Name == productName);

                if (person != null && product != null)
                {
                    person.BuyProduct(product);
                }

                command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var person in people)
            {
                List<string> boughtProducts = person.Products.Select(p => p.Name).ToList();

                if (boughtProducts.Count == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }

                else
                {
                    Console.WriteLine($"{ person.Name} - {String.Join(", ", boughtProducts)}");
                }
            }
        }
    }
}
