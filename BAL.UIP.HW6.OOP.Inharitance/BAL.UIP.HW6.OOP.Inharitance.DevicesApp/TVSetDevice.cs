using System;

namespace BAL.UIP.HW6.OOP.Inharitance.DevicesApp
{
    abstract class TVSetDevice : Device
    {
        private int _ScreenDiagonal;

        public TVSetDevice(string name, int power, int screenDiagonal) : base(name, power)
        {
            this.ScreenDiagonal = screenDiagonal;
        }

        public int ScreenDiagonal
        {
            get
            {
                return this._ScreenDiagonal;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"Zero or negative Screen Diagonal value: '{value}'");
                    return;
                }
                this._ScreenDiagonal = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}Screen Diagonal Size: {this.ScreenDiagonal}\"\n";
        }
    }

}