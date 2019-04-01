using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.UIP.ClassWork._20190330.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Country country = new Country("Ukraine");
            List<Order> orders = country.GenerateNewOrders(20);

            List<Worker> workers = Country.HireWorkers(5);

            Plant plant = new Plant("Power Plant", workers, country);

            plant.StartNewWorkingYear();

            Console.ReadLine();
        }
    }
}
