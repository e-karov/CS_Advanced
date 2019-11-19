using System;
using Wild_Farm.Foods;

namespace Wild_Farm.Animals.Birds
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name == "Meat" )
            {
                this.Weight += (.25 * food.Quantity);
                this.FoodEaten += food.Quantity;
            }

            else
            {
                Console.WriteLine($"Owl does not eat {food.GetType().Name}");
            }
        }

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
    }
}
