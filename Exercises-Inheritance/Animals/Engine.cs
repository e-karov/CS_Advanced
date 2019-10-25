using Animals.Cats;
using System;

namespace Animals
{
    public class Engine
    {
        public void Run()
        {
            string command;


            while ((command = Console.ReadLine()) != "Beast!")
            {
                string animalType = command;
                string[] animalInfo = Console.ReadLine().Split();

                try
                {
                    string name = animalInfo[0];

                    if (int.TryParse(animalInfo[1], out int age))
                    {

                        switch (animalType.ToLower())
                        {
                            case "cat":

                                string gender = animalInfo[2];
                                Cat cat = new Cat(name, age, gender);
                                Console.WriteLine(cat);
                                break;

                            case "tomcat":

                                Tomcat tomcat = new Tomcat(name, age);
                                Console.WriteLine(tomcat);
                                break;

                            case "kitten":

                                Kitten kitten = new Kitten(name, age);
                                Console.WriteLine(kitten);
                                break;

                            case "dog":

                                gender = animalInfo[2];
                                Dog dog = new Dog(name, age, gender);
                                Console.WriteLine(dog);
                                break;

                            case "frog":

                                gender = animalInfo[2];
                                Frog frog = new Frog(name, age, gender);
                                Console.WriteLine(frog);
                                break;

                            default:

                                Console.WriteLine("Invalid input!");

                                break;
                        }

                    }

                }
                catch (ArgumentException ae)
                {

                    Console.WriteLine(ae.Message);
                }

            }
        }

    }
}
