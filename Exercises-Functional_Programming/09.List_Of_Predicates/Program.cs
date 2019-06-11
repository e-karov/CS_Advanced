using System;
using System.Collections.Generic;
using System.Linq;


namespace _09.List_Of_Predicates
{
    public class StartUp
    {
        public static void Main()
        {
            int rangeLimit = int.Parse(Console.ReadLine());

            List<int> range = Enumerable.Range(1, rangeLimit).ToList();

            HashSet<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToHashSet();

            //foreach (var divider in dividers)
            //{
            //    Predicate<int> divisible = num => { return num % divider == 0; };

            //    range = range.FindAll(divisible);
            //}

            List<Predicate<int>> dividers = new List<Predicate<int>>();

            foreach (var number in numbers)
            {
                dividers.Add(x => x % number == 0);
            }

            for (int i = 0; i < range.Count; i++)
            {
                foreach (var divider in dividers)
                {
                    if (!divider(range[i]))
                    {
                        range.Remove(range[i]);
                        i--;
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", range));
        }
    }
}
