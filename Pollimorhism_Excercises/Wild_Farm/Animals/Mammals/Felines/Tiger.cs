using System;
using Wild_Farm.Foods;

namespace Wild_Farm.Animals.Mammals.Felines
{
    public class Tiger : Feline
    {
        public Tiger(string name, string breed, double weight, string livingRegion) 
            : base(name, breed, weight, livingRegion)
        {
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name == "Meat")
            {
                this.Weight += (1.00 * food.Quantity);
                this.FoodEaten += food.Quantity;
            }

            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
    }
}
