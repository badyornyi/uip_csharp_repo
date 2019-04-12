using System;

namespace BAL.UIP.HW6.OOP.Inharitance.DevicesApp
{
    internal sealed class PlazmaTVSetDevice : TVSetDevice
    {
        private string _ScreenAspectRatio;

        public PlazmaTVSetDevice(string name, int power, int screenDiagonal, string screenAspectRatio) : base(name, power, screenDiagonal)
        {
            this.ScreenAspectRatio = screenAspectRatio;
        }

        public string ScreenAspectRatio
        {
            get
            {
                return this._ScreenAspectRatio;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine($"Zero or negative Screen Aspect Ratio value: '{value}'");
                    return;
                }
                this._ScreenAspectRatio = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}Screen Aspect Ratio: {this.ScreenAspectRatio}\n";
        }
    }

}