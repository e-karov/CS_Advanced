namespace P02_CarsSalesman
{
    using System.Text;


    public class Engine
    {
        private const string offset = "  ";
        private const string defaultEfficiencyValue = "n/a";

        private int displacement;
        private string efficiency;

        public Engine(string model, int power)
            :this(model, power, -1, defaultEfficiencyValue)
        {
        }

        public Engine(string model, int power, int displacement)
            : this(model, power, displacement, defaultEfficiencyValue)
        {
        }

        public Engine(string model, int power, string efficiency)
            :this(model, power, -1, efficiency)
        {
        }

        public Engine(string model, int power, int displacement, string efficiency)
           
        {
            this.Model = model;
            this.Power = power;
            this.displacement = displacement;
            this.efficiency = efficiency;
        }

        public string Model { get; private set; }

        public int Power { get; private set; }

       



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{offset}{this.Model}:");
            sb.AppendLine($"{offset}{offset}Power: {this.Power}");

            if (this.displacement == -1)
            {
                sb.AppendLine($"{offset}{offset}Displacement: n/a");
            }

            else
            {
                sb.AppendLine($"{offset}{offset}Displacement: {this.displacement}");
            }
            
            sb.AppendLine($"{offset}{offset}Efficiency: {this.efficiency}");

            return sb.ToString();
        }
    }
}
