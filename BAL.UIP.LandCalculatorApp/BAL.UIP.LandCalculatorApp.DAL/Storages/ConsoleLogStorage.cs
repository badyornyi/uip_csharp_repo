using BAL.UIP.LandCalculatorApp.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.UIP.LandCalculatorApp.DAL.Storages
{
    public class ConsoleLogStorage : ILogStorage
    {
        public void PrintMessage(string message)
        {
            Console.WriteLine($"ConsoleLogStorage: {message}");
        }
    }
}
