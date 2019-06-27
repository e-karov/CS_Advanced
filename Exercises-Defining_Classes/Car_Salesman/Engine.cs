using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Salesman
{
    public class Engine
    {
        public string Model { get; set; }

        public string Power { get; set; }

        public string Displacement { get; set; } = "n/a";

        public string Efficiency { get; set; } = "n/a";

        public Engine()
        {

        }

        public Engine (string model, string power)
        {
            this.Model = model;
            this.Power = power;
        }
    }
}
