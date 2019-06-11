using System;
using System.Linq;

namespace _01.Action_Point              // 100 / 100
{
    public class StartUp
    {
        public static void Main( )
        {
            string[] names = Console.ReadLine()
                .Split();

            Action<string[]> printNames = name => Console.WriteLine(String.Join(Environment.NewLine, name));

            printNames(names);
        }
    }
}
