using System;

namespace BAL.UIP.HW6.OOP.Inharitance.DevicesApp
{
    internal class LaptopComputerDevice : ComputerDevice
    {
        private double _Weight;

        public LaptopComputerDevice(string name, int power, int ramSize, double weight) : base(name, power, ramSize)
        {
            this.Weight = weight;
        }

        public double Weight
        {
            get
            {
                return this._Weight;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"Zero or negative Weight value: '{value}'");
                    return;
                }
                this._Weight = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}Weight: {this.Weight}kg\n";
        }
    }

}