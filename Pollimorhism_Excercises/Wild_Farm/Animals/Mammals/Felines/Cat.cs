using System;
using Wild_Farm.Foods;

namespace Wild_Farm.Animals.Mammals.Felines
{
    public class Cat : Feline
    {
        public Cat(string name, string breed, double weight, string livingRegion) 
            : base(name, breed, weight, livingRegion)
        {
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name == "Vegetable" || food.GetType().Name == "Meat")
            {
                this.Weight += (.30 * food.Quantity);
                this.FoodEaten += food.Quantity;
            }

            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
