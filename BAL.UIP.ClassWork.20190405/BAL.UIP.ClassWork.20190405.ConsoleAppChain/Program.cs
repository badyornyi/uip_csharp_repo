using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.UIP.ClassWork._20190405.ConsoleAppChain
{
    class Program
    {
        static void Main(string[] args)
        {
            Generator generator = new Generator() { GeneratedPower = 1000 };
            ConsumptionDevice consumptionDevice1 = new ConsumptionDevice() { ConsumptionPower = 700 };
            ConsumptionDevice consumptionDevice2 = new ConsumptionDevice() { ConsumptionPower = 700 };
            ConsumptionDevice consumptionDevice3 = new ConsumptionDevice() { ConsumptionPower = 700 };
            ConsumptionDevice consumptionDevice4 = new ConsumptionDevice() { ConsumptionPower = 700 };

            generator.PlugDevice(consumptionDevice1);
            consumptionDevice1.PlugDevice(consumptionDevice2);
            consumptionDevice2.PlugDevice(consumptionDevice3);
            consumptionDevice3.PlugDevice(consumptionDevice4);
            

            Console.ReadLine();
        }
    }

    internal class ElectricDevice
    {
        public ElectricDevice NextConnectedDevice { get; set; }
        public virtual int AvailablePower { get; }

        public bool PlugDevice(ConsumptionDevice nextDevice)
        {
            if (this.NextConnectedDevice != null || this.AvailablePower < nextDevice.ConsumptionPower)
            {
                return false;
            }
            this.NextConnectedDevice = nextDevice;
            nextDevice.PreviousConnectedDevice = this;
            return true;
        }

        public void UnplugDevice()
        {

        }
    }

    internal class Generator : ElectricDevice
    {
        public int GeneratedPower;
        //public override int AvailablePower => this.GeneratedPower;
        public override int AvailablePower
        {
            get
            {
                return this.GeneratedPower;
            }
        }
    }

    internal class ConsumptionDevice : ElectricDevice
    {
        public int ConsumptionPower { get; set; }
        public ElectricDevice PreviousConnectedDevice { get; set; }

        public override int AvailablePower
        {
            get
            {
                return PreviousConnectedDevice.AvailablePower - this.ConsumptionPower;
            }
        }
    }
}
