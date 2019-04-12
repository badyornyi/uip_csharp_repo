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

            ////servers
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

            Console.WriteLine(laptop01.ToString());
            Console.WriteLine(laptop01.ToString());
            Console.WriteLine(laptop02.ToString());
            Console.WriteLine(server01.ToString());
            Console.WriteLine(server02.ToString());
            Console.WriteLine(plazmaTV01.ToString());
            Console.WriteLine(plazmaTV02.ToString());
            Console.WriteLine(eltTV01.ToString());
            Console.WriteLine(eltTV02.ToString());
            Console.WriteLine(player01.ToString());
            Console.WriteLine(player02.ToString());

            Console.ReadLine();
        }
    }

}