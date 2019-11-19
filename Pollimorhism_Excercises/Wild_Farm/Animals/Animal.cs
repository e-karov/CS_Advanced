using Wild_Farm.Foods;

namespace Wild_Farm.Animals
{
    public abstract class Animal 
    {
        protected Animal (string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name { get; protected set; }

        public double Weight { get; protected set; }

        public int FoodEaten { get; protected set; }

        public abstract string ProduceSound();

        public abstract void Eat(Food food);

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name},";
        }
    }
}
