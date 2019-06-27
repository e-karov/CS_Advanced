using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Salesman
{
    public class Car
    {
        public string Model { get; set; }

        public Engine  Engine { get; set; }

        public string Weight { get; set; } = "n/a";

        public string Color { get; set; } = "n/a";

        public Car()
        {

        }

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }

        public override string ToString()
        {
            StringBuilder printPattern = new StringBuilder ($"{this.Model}:"+Environment.NewLine);
            printPattern.AppendLine($"  {this.Engine.Model}:");
            printPattern.AppendLine($"    Power: {this.Engine.Power}");
            printPattern.AppendLine($"    Displacement: {this.Engine.Displacement}");
            printPattern.AppendLine($"    Efficiency: {this.Engine.Efficiency}");
            printPattern.AppendLine($"  Weight: {this.Weight}");
            printPattern.Append($"  Color: {this.Color}");

            return printPattern.ToString();
        }
    }
}
