using System;
using System.Linq;


namespace _02.Knights_Honor                         // 100 / 100
{
    public  class StartUp
    {
        public static void Main( )
        {
            string[] names = Console.ReadLine()
                .Split();

            Action<string[]> printNames = name => Console.WriteLine("Sir "+String.Join(Environment.NewLine + "Sir ", name));

            printNames(names);
        }
    }
}
