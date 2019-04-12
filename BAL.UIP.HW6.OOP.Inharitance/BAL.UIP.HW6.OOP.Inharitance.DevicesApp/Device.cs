using System;

namespace BAL.UIP.HW6.OOP.Inharitance.DevicesApp
{
    // top parent class

    abstract class Device
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

        public override string ToString()
        {
            return $"Type: {this.GetType()}\nName: {this.Name}\nPower: {this.Power}W\n";
        }
    }

}