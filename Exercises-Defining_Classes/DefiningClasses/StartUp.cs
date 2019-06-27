using System;
using System.Collections.Generic;
using System.Linq;


namespace DefiningClasses                           
{
    public class StartUp
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            List<Person> persons = new List<Person>();

            for (int i = 0; i < count; i++)
            {
                string[] personData = Console.ReadLine().Split();

                string name = personData[0];
                int age = int.Parse(personData[1]);

                Person person = new Person(name, age);

                persons.Add(person);
            }

            persons = persons
                .Where(p => p.Age > 30)
                .OrderBy(p => p.Name)
                .ToList();

            foreach (var person in persons)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
