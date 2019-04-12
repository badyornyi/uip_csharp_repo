using System;

namespace BAL.UIP.HW6.OOP.Inharitance.DevicesApp
{
    internal class ELTTVSetDevice : TVSetDevice
    {
        private string _RasterScanningFrequency;

        public ELTTVSetDevice(string name, int power, int screenDiagonal, string rasterScanningFrequency) : base(name, power, screenDiagonal)
        {
            this.RasterScanningFrequency = rasterScanningFrequency;
        }

        public string RasterScanningFrequency
        {
            get
            {
                return this._RasterScanningFrequency;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine($"Zero or negative Raster Scanning Frequency value: '{value}'");
                    return;
                }
                this._RasterScanningFrequency = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}Raster Scanning Frequency: {this.RasterScanningFrequency}\n";
        }
    }

}