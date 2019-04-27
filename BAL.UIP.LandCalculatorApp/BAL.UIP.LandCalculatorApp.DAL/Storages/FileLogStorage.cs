﻿using BAL.UIP.LandCalculatorApp.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.UIP.LandCalculatorApp.DAL.Storages
{
    public class FileLogStorage : ILogStorage
    {
        public void PrintMessage(string message)
        {
            Console.WriteLine($"FileLogStorage: {message}");
        }
    }
}
