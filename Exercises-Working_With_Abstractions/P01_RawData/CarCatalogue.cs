using System.Collections.Generic;

namespace P01_RawData
{
    public class CarCatalogue
    {
        private List<Car> cars;

        public CarCatalogue()
        {
            this.cars = new List<Car>();
        }

        public List<Car> GetCars()
        {
            return this.cars;
        }

        public void Add(Car car)
        {
            this.cars.Add(car);
        }
    }
}
