namespace PizzaCalories
{
    using System;
    using System.Collections.Generic;


    public class Dough
    {
        private const double DefaultCalories = 2;

        private string flourType;
        private string backingTechique;
        private double weight;

        private Dictionary<string, double> validFlourTypes;
        private Dictionary<string, double> validBackingTechniques;

        public Dough(String flourType, string backingTechnique, double weight)
        {
            this.validFlourTypes = new Dictionary<string, double>();
            this.validBackingTechniques = new Dictionary<string, double>();
            this.SeedFlourTypes();
            this.SeedBackingTechniques();

            this.FloutType = flourType;
            this.BackingTechique = backingTechnique;
            this.Weight = weight;
        }


        public string FloutType
        {
            get => this.flourType;

            private set
            {
                if (!validFlourTypes.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.flourType = value;
            }
        }

        public string BackingTechique
        {
            get => this.backingTechique;

            private set
            {
                if (!this.validBackingTechniques.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.backingTechique = value;
            }
        }

        public double Weight
        {
            get => this.weight;

            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                this.weight = value;
            }
        }

        public double CaloriesPerGram
        {
            get
            {
                return DefaultCalories * this.validFlourTypes[this.flourType.ToLower()] * this.validBackingTechniques[this.backingTechique.ToLower()];
            }
        }

        public double GetTotalCalories()
        {
            double totalCalories = this.CaloriesPerGram * this.weight;

            return totalCalories;
        }

        private void SeedFlourTypes()
        {
            this.validFlourTypes.Add("white", 1.5);
            this.validFlourTypes.Add("wholegrain", 1.0);
        }

        private void SeedBackingTechniques()
        {
            this.validBackingTechniques.Add("crispy", 0.9);
            this.validBackingTechniques.Add("chewy", 1.1);
            this.validBackingTechniques.Add("homemade", 1.0);
        }

    }
}
