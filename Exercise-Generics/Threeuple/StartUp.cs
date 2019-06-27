using System;
using System.Text;

namespace Threeuple             
{
    public class StartUp
    {
        public static void Main()
        {
            string[] firstLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string names = $"{firstLine[0]} {firstLine[1]}";
            string address = firstLine[2];
            string town = firstLine[3];

            var threeuple1 = new Threeuple<string, string, string>(names, address, town);

            string[] secondLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string name = secondLine[0];
            double beerAmount = double.Parse(secondLine[1]);
            bool IsDrunk = secondLine[2].ToLower() == "drunk";
            
            var threeuple2 = new Threeuple<string, double, bool>(name, beerAmount, IsDrunk);

            string[] thirdLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string name2 = thirdLine[0];
            double accountBalance   = double.Parse(thirdLine[1]);
            string bankName = thirdLine[2];

            var threeuple3 = new Threeuple<string, double, string>(name2, accountBalance, bankName);

            Console.WriteLine(threeuple1);
            Console.WriteLine(threeuple2);
            Console.WriteLine(threeuple3);
        }

       
    }
}
