using System;

namespace BAL.UIP.HW6.OOP.Inharitance.DevicesApp
{
    abstract class ComputerDevice : Device
    {
        private int _RAMSize;

        public ComputerDevice(string name, int power, int ramSize) : base(name, power)
        {
            this.RAMSize = ramSize;
        }

        public int RAMSize
        {
            get
            {
                return this._RAMSize;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"Zero or negative RAM Size value: '{value}'");
                    return;
                }
                this._RAMSize = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}RAM Size: {this.RAMSize}GB\n";
        }
    }

}