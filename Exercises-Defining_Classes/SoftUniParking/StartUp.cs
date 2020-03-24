namespace SoftUniParking                    // 100 / 100
{
    using System;


    public class StartUp
    {
        public static void Main()
        {
            var car = new Car("Skoda", "Fabia", 65, "CC1856BG");
            var car2 = new Car("Audi", "A3", 110, "EB8787MN");
            var car3 = new Car("Audi", "A3", 110, "BB8787MN");

            var parking = new Parking(2);

            Console.WriteLine(parking.AddCar(car));
            Console.WriteLine(parking.AddCar(car2));
            Console.WriteLine(parking.RemoveCar("CC1856B"));
            Console.WriteLine(parking.GetCar("CC1856BG"));
            Console.WriteLine(parking.Count);
        }
    }
}
