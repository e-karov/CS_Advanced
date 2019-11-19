using System;
using System.Collections.Generic;
using Wild_Farm.Animals;
using Wild_Farm.Animals.Birds;
using Wild_Farm.Animals.Mammals;
using Wild_Farm.Animals.Mammals.Felines;
using Wild_Farm.Foods;

namespace Wild_Farm.Core
{
    public static class Engine
    {
        public static void Run()
        {
            List<Animal> animals = new List<Animal>();

            string input = "";

            while ((input = Console.ReadLine()) != "End")
            {
                string[] animalInfo = input.Split();
                string[] foodInfo = Console.ReadLine().Split();


                string foodName = foodInfo[0];
                int foodQuantity = int.Parse(foodInfo[1]);

                Food food = GetFood(foodName, foodQuantity);

                Animal animal = CreateAnimal(animalInfo);

                Console.WriteLine(animal.ProduceSound()); 

                animal.Eat(food);

                animals.Add(animal);
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        private static Animal CreateAnimal(string[] animalInfo)
        {
            Animal animal = null;

            string type = animalInfo[0];
            string name = animalInfo[1];
            double weight = double.Parse(animalInfo[2]);

            switch (type)
            {
                case "Cat":
                case "Tiger":

                    string livingRegion = animalInfo[3];
                    string breed = animalInfo[4];

                    if (type == "Cat")
                    {
                        animal = new Cat(name, breed, weight, livingRegion);

                    }

                    else if (type == "Tiger")
                    {
                        animal = new Tiger(name, breed, weight, livingRegion);

                    }
                    break;

                case "Hen":
                case "Owl":

                    double wingSize = double.Parse(animalInfo[3]);

                    if (type == "Owl")
                    {
                        animal = new Owl(name, weight, wingSize);

                    }

                    else if (type == "Hen")
                    {
                        animal = new Hen(name, weight, wingSize);

                    }
                    break;

                case "Mouse":
                case "Dog":

                    livingRegion = animalInfo[3];

                    if (type == "Mouse")
                    {
                        animal = new Mouse(name, weight, livingRegion);

                    }

                    else if (type == "Dog")
                    {
                       animal = new Dog(name, weight, livingRegion);

                    }
                    break;
            }

            return animal;
        }

        private static Food GetFood(string name, int quantity)
        {
            Food food = null;

            if (name == "Vegetable")
            {
                food = new Vegetable(quantity);
            }

            else if (name == "Fruit")
            {
                food = new Fruit(quantity);
            }

            else if (name == "Meat")
            {
                food = new Meat(quantity);
            }

            else if (name == "Seeds")
            {
                food = new Seeds(quantity);
            }

            return food;
        }


    }
}
