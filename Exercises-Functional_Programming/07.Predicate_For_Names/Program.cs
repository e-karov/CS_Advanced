using System;
using System.Linq;


namespace _07.Predicate_For_Names               // 100 / 100
{
    public class StartUp
    {
        public static void Main()
        {
            int len = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine()
                .Split();

            Predicate<string> lengthCheck = name => name.Length <= len;

            Func<string[], string[]> lengthFilter = array => array.Where(n => lengthCheck(n)).ToArray();

            Action<string[]> printNames = arr => Console.WriteLine(String.Join(Environment.NewLine, arr));

            printNames(lengthFilter(names));
        }
    }
}
