using System;

namespace CarSalesman
{
    public class Engine
    {
        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }

        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = -1;
            this.Efficiency = null;
        }
        public Engine(string model, int power, int displacement):this(model, power)
        {
            this.Displacement = displacement;
        }
        public Engine(string model, int power, string efficiency):this(model, power)
        {
            this.Efficiency = efficiency;
        }
        public Engine(string model, int power, int displacement, string efficiency) : this(model, power)
        {
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }

        public override string ToString()
        {
            string displacement = Displacement == -1 ? "n/a" : Displacement.ToString();
            string efficiency = Efficiency ?? "n/a";

            string result =
                $"{Model}:{Environment.NewLine}" +
                $"    Power: {Power}{Environment.NewLine}" +
                $"    Displacement: {displacement}{Environment.NewLine}" +
                $"    Efficiency: {efficiency}";

            return result;
        }
    }
}