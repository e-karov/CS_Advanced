using System;
using System.Collections.Generic;

namespace Tuple
{
    public class StartUp
    {
        public static void Main()
        {

            string[] firstLine = Console.ReadLine().Split();
            string names = $"{firstLine[0]} {firstLine[1]}";
            string address = firstLine[2];

            Tuple<string, string> tuple = new Tuple<string, string>(names, address);

            Console.WriteLine(tuple);

            string[] secondLIne = Console.ReadLine().Split();
            string name = secondLIne[0];
            int beerAmount = int.Parse(secondLIne[1]);

            Tuple<string, int> tuple1 = new Tuple<string, int>(name, beerAmount);

            Console.WriteLine(tuple1);

            string[] thirdLine = Console.ReadLine().Split();
            int integer = int.Parse(thirdLine[0]);
            double number = double.Parse(thirdLine[1]);

            Tuple<int, double> tuple2 = new Tuple<int, double>(integer, number);

            Console.WriteLine(tuple2);
        }
    }
}
