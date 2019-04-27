using BAL.UIP.LandCalculatorApp.BLL.Service;
using BAL.UIP.LandCalculatorApp.DAL.Storages;
using BAL.UIP.LandCalculatorApp.Shared;
using BAL.UIP.LandCalculatorApp.Shared.Interfaces;
using BAL.UIP.LandCalculatorApp.Shared.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.UIP.LandCalculatorApp.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            InitializeStorages();

            StaticInjector.Logger.Info("Program is started");

            new UIConsoleInteractor(new LandAreaCalculator()).Start();

            Console.ReadLine();
        }

        private static void InitializeStorages()
        {
            StaticInjector.Logger.LogStorages.Add(new ConsoleLogStorage());
            StaticInjector.Logger.LogStorages.Add(new FileLogStorage());
        }
    }
}
