using BAL.UIP.LandCalculatorApp.Shared.Interfaces;
using BAL.UIP.LandCalculatorApp.Shared.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.UIP.LandCalculatorApp.Shared
{
    public static class StaticInjector
    {
        public static ILogger Logger { get; } = new Logger();
    }
}
