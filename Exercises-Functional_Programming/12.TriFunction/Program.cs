using System;
using System.Linq;


namespace _12.TriFunction                       // 100 / 100
{
    public class StartUp
    {
        public static void Main()
        {
            int charSum = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split();

            Func<string, int, bool> isLarger = (name, characterSum) => name.Sum(c => c) >= characterSum;

            Func<string[], Func<string, int, bool>, string> nameFinder = (inputNames, isLargerFilter) =>
            inputNames.FirstOrDefault(n => isLargerFilter(n, charSum));

            string nameFound = nameFinder(names, isLarger);

            Console.WriteLine(nameFound);
        }
    }
}
