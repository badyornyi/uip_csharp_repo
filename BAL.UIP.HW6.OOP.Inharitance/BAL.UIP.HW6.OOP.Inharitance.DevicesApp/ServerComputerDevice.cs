using System;

namespace BAL.UIP.HW6.OOP.Inharitance.DevicesApp
{
    internal class ServerComputerDevice : ComputerDevice
    {
        private int _ProcessorsCount;

        public ServerComputerDevice(string name, int power, int ramSize, int processorsCount) : base(name, power, ramSize)
        {
            this.ProcessorsCount = processorsCount;
        }

        public int ProcessorsCount
        {
            get
            {
                return this._ProcessorsCount;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"Zero or negative Processors Count value: '{value}'");
                    return;
                }
                this._ProcessorsCount = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}Processors Count: {this.ProcessorsCount}\n";
        }
    }

}