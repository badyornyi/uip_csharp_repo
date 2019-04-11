using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.UIP.HW6.OOP.Inharitance.DevicesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //laptops
            LaptopComputerDevice laptop01 = new LaptopComputerDevice("Lenovo", 50, 8, 2.5);
            LaptopComputerDevice laptop02 = new LaptopComputerDevice("Samsung", 40, 16, 3.2);

            //servers
            ServerComputerDevice server01 = new ServerComputerDevice("Cisco", 850, 32, 8);
            ServerComputerDevice server02 = new ServerComputerDevice("Dell", 1100, 64, 16);

            //plazma tv
            PlazmaTVSetDevice plazmaTV01 = new PlazmaTVSetDevice("LG", 140, 52, "16X9");
            PlazmaTVSetDevice plazmaTV02 = new PlazmaTVSetDevice("Sony", 120, 61, "16X10");

            //elt tv
            ELTTVSetDevice eltTV01 = new ELTTVSetDevice("JVC", 180, 21, "50Hz");
            ELTTVSetDevice eltTV02 = new ELTTVSetDevice("Panasonic", 150, 24, "60Hz");

            //player
            PlayerDevice player01 = new PlayerDevice("iPod", 2, new string[] { "*.mp3", "*.wav", "*.ogg" });
            PlayerDevice player02 = new PlayerDevice("Transcend", 1, new string[] { "*.mp3", "*.wav", "*.ogg", "*.acc" });

            Console.WriteLine(laptop01.GetDescription());
            Console.WriteLine(laptop02.GetDescription());
            Console.WriteLine(server01.GetDescription());
            Console.WriteLine(server02.GetDescription());
            Console.WriteLine(plazmaTV01.GetDescription());
            Console.WriteLine(plazmaTV02.GetDescription());
            Console.WriteLine(eltTV01.GetDescription());
            Console.WriteLine(eltTV02.GetDescription());
            Console.WriteLine(player01.GetDescription());
            Console.WriteLine(player02.GetDescription());

            Console.ReadLine();
        }
    }

    // top parent class

    public class Device
    {
        private string _Name;
        private int _Power;

        public Device(string name, int power)
        {
            this.Name = name;
            this.Power = power;
        }

        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine($"Empty or incorrect Device Name: '{value}'");
                    return;
                }
                this._Name = value;
            }
        }

        public int Power
        {
            get
            {
                return this._Power;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"Zero or negative Power value: '{value}'");
                    return;
                }
                this._Power = value;
            }
        }

        public virtual string GetDescription()
        {
            string descriptionTitle = "Class Device description:\n";
            string descriptionName = $"Name: {this.Name}\n";
            string descriptionPower = $"Power: {this.Power}W\n";
            string description = descriptionTitle + descriptionName + descriptionPower;
            return description;
        }
    }

    // child classes of Device

    public class PlayerDevice : Device
    {
        //private string[] _Formats;

        public PlayerDevice(string name, int power, string[] formats) : base(name, power)
        {
            this.Formats = formats;
        }

        public string[] Formats { get; set; }

        public override string GetDescription()
        {
            string descriptionTitle = "Class PlayerDevice description:\n";
            string descriptionName = $"Name: {this.Name}\n";
            string descriptionPower = $"Power: {this.Power}W\n";
            string descriptionFormats = $"Formats Number: {this.Formats.Length}\n";
            //string descriptionFormats = $"Formats: {this.Formats.ToString()}\n";
            string description = descriptionTitle + descriptionName + descriptionPower + descriptionFormats;
            return description;
        }
    }

    public class ComputerDevice : Device
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

        public override string GetDescription()
        {
            string descriptionTitle = "Class ComputerDevice description:\n";
            string descriptionName = $"Name: {this.Name}\n";
            string descriptionPower = $"Power: {this.Power}W\n";
            string descriptionRAMSize = $"RAM Size: {this.RAMSize}GB\n";
            string description = descriptionTitle + descriptionName + descriptionPower + descriptionRAMSize;
            return description;
        }
    }

    public class TVSetDevice : Device
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

        public override string GetDescription()
        {
            string descriptionTitle = "Class TVSetDevice description:\n";
            string descriptionName = $"Name: {this.Name}\n";
            string descriptionPower = $"Power: {this.Power}W\n";
            string descriptionScreenDiagonal = $"Screen Diagonal Size: {this.ScreenDiagonal}\"\n";
            string description = descriptionTitle + descriptionName + descriptionPower + descriptionScreenDiagonal;
            return description;
        }
    }

    // child classes of Computer Class

    public class LaptopComputerDevice : ComputerDevice
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

        public override string GetDescription()
        {
            string descriptionTitle = "Class LaptopComputerDevice description:\n";
            string descriptionName = $"Name: {this.Name}\n";
            string descriptionPower = $"Power: {this.Power}W\n";
            string descriptionRAMSize = $"RAM Size: {this.RAMSize}GB\n";
            string descriptionWeight = $"Weight: {this.Weight}kg\n";
            string description = descriptionTitle + descriptionName + descriptionPower + descriptionRAMSize + descriptionWeight;
            return description;
        }
    }

    public class ServerComputerDevice : ComputerDevice
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

        public override string GetDescription()
        {
            string descriptionTitle = "Class ServerComputerDevice description:\n";
            string descriptionName = $"Name: {this.Name}\n";
            string descriptionPower = $"Power: {this.Power}W\n";
            string descriptionRAMSize = $"RAM Size: {this.RAMSize}GB\n";
            string descriptionProcessorsCount = $"Processors Count: {this.ProcessorsCount}\n";
            string description = descriptionTitle + descriptionName + descriptionPower + descriptionRAMSize + descriptionProcessorsCount;
            return description;
        }
    }

    // child classes of TVSet Class

    public class PlazmaTVSetDevice : TVSetDevice
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

        public override string GetDescription()
        {
            string descriptionTitle = "Class PlazmaTVSetDevice description:\n";
            string descriptionName = $"Name: {this.Name}\n";
            string descriptionPower = $"Power: {this.Power}W\n";
            string descriptionScreenDiagonal = $"Screen Diagonal Size: {this.ScreenDiagonal}\"\n";
            string descriptionScreenAspectRatio = $"Screen Aspect Ratio: {this.ScreenAspectRatio}\n";
            string description = descriptionTitle + descriptionName + descriptionPower + descriptionScreenDiagonal + descriptionScreenAspectRatio;
            return description;
        }
    }

    public class ELTTVSetDevice : TVSetDevice
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

        public override string GetDescription()
        {
            string descriptionTitle = "Class ELTTVSetDevice description:\n";
            string descriptionName = $"Name: {this.Name}\n";
            string descriptionPower = $"Power: {this.Power}W\n";
            string descriptionScreenDiagonal = $"Screen Diagonal Size: {this.ScreenDiagonal}\"\n";
            string descriptionRasterScanningFrequency = $"Raster Scanning Frequency: {this.RasterScanningFrequency}\n";
            string description = descriptionTitle + descriptionName + descriptionPower + descriptionScreenDiagonal + descriptionRasterScanningFrequency;
            return description;
        }
    }

}