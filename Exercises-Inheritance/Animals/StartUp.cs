namespace Animals
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            while (input != "Beast!")
            {
                if (input == "Beast!")
                {
                    break;
                }

                string animalType = input;
                string[] animalInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = animalInfo[0];
                int age = int.Parse(animalInfo[1]);
                string gender = animalInfo[2];

                switch (animalType)
                {
                   
                    case "Dog":
                        Dog dog = new Dog(name, age, gender);
                        Console.WriteLine(animalType);
                        Console.WriteLine(dog);

                        break;

                    case "Frog":
                        Frog frog = new Frog(name, age, gender);
                        Console.WriteLine(animalType);
                        Console.WriteLine(frog);

                        break;

                    case "Cat":
                        Cat cat = new Cat(name, age, gender);
                        Console.WriteLine(animalType);
                        Console.WriteLine(cat);

                        break;

                    case "Kitten":
                        Kitten kitten = new Kitten(name, age);
                        Console.WriteLine(animalType);
                        Console.WriteLine(kitten);

                        break;

                    case "Tomcat":
                        Tomcat tomcat = new Tomcat(name, age);
                        Console.WriteLine(animalType);
                        Console.WriteLine(tomcat);
                        break;

                    default:
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
