using System;
using System.Collections.Generic;
using System.Text;

namespace Row_Data
{
    class Car
    {
        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Tire[] Tires { get; set; }

        public Cargo Cargo { get; set; }

        public Car(string model, Engine engine, Tire[] tires, Cargo cargo)
        {
            this.Model = model;
            this.Engine = new Engine(engine.Speed, engine.Power);
            this.Tires =  new Tire[4];
            Tires = tires;
            this.Cargo = new Cargo(cargo.Type, cargo.Weight);


        }
    }
}
