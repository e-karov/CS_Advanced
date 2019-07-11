namespace PizzaCalories
{
    using System;


    public class StartUp
    {
        static void Main()
        {
            try
            {
                string[] pizzaArgs = Console.ReadLine().Split();
                string pizzaName = pizzaArgs[1];

                string[] doughArgs = Console.ReadLine().Split();
                string flourType = doughArgs[1];
                string backingTechnique = doughArgs[2];
                double weight = double.Parse(doughArgs[3]);

                Dough dough = new Dough(flourType, backingTechnique, weight);

                Pizza pizza = new Pizza(pizzaName, dough);

                string[] toppingArgs = Console.ReadLine().Split();

                while (toppingArgs[0] != "END")
                {
                    string toppingType = toppingArgs[1];
                    double toppingWeight = double.Parse(toppingArgs[2]);

                    Topping topping = new Topping(toppingType, toppingWeight);

                    pizza.AddTopping(topping);

                    toppingArgs = Console.ReadLine().Split();
                }

                Console.WriteLine($"{pizza.Name} - {pizza.GetTotalCalories().ToString("f2")} Calories.");
            }

            catch (ArgumentException ae)
            {

                Console.WriteLine(ae.Message);
            }

            catch (InvalidOperationException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
        }
    }
}
