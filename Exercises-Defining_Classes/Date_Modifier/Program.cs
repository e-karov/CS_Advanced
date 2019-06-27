using System;

namespace Date_Modifier
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string startDate = Console.ReadLine();
            string endDate = Console.ReadLine();

            DateModifier dateModifier = new DateModifier(startDate, endDate);

            Console.WriteLine(dateModifier.DaysDifference());

        }
    }
}
