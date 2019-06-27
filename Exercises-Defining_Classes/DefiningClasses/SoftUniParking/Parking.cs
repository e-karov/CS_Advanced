﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {
        private Dictionary<string, Car> cars;

        private int capacity;


        public int Count => cars.Count;
        //{
        //    get { return cars.Count; }
        //            или
        //    get => cars.Count;
        //}


        public Parking(int capacity)
        {
            this.capacity = capacity;

            cars = new Dictionary<string, Car>();
        }

        public string AddCar(Car car)
        {
            if (cars.ContainsKey(car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }

            if (cars.Count == capacity)
            {
                return "Parking is full!";
            }

            else
            {
                cars.Add(car.RegistrationNumber, car);

                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";

            }
        }

        public string RemoveCar(string registrationNumber)
        {
            if (cars.ContainsKey(registrationNumber) == false)
            {
               return "Car with that registration number, doesn't exist!";
            }

            else
            {
                cars.Remove(registrationNumber);
                return $"Successfully removed {registrationNumber}";
            }
        }

        public Car GetCar(string registrationNumber)
        {
            if (cars.ContainsKey(registrationNumber))
            {
                return cars[registrationNumber];
            }
            return null;
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var number in registrationNumbers)
            {
                RemoveCar(number);
            }
        }
    }
}
