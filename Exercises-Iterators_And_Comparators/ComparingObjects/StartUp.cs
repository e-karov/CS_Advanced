using System;
using System.Collections.Generic;

namespace ComparingObjects                      // 100 / 100
{
    public class Program
    {
        public static void Main()
        {
            List<Person> persons = new List<Person>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] tokens = input.Split();

                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string town = tokens[2];

                var person = new Person(name, age, town);
                persons.Add(person);

                input = Console.ReadLine();
            }

            int n = int.Parse(Console.ReadLine());

            int matchesCount = 1;
            int notEqualPersonsCount = 0;

            var targetPerson = persons[n - 1];

            foreach (var person in persons)
            {
                if (person == targetPerson)
                {
                    continue;
                }

                if (person.CompareTo(targetPerson) == 0)
                {
                    matchesCount++;
                }

                else
                {
                    notEqualPersonsCount++;
                }
            }

            if (matchesCount == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{matchesCount} {notEqualPersonsCount} {persons.Count}");
            }
        }
    }
}
