namespace BAL.UIP.HW6.OOP.Inharitance.DevicesApp
{
    // child classes of Device

    internal class PlayerDevice : Device
    {
        //private string[] _Formats;

        public PlayerDevice(string name, int power, string[] formats) : base(name, power)
        {
            this.Formats = formats;
        }

        public string[] Formats { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}Formats Number: { this.Formats.Length}\n";
        }
    }

}