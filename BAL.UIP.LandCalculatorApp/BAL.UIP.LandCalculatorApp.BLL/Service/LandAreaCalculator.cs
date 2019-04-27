using BAL.UIP.LandCalculatorApp.Shared;
using BAL.UIP.LandCalculatorApp.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.UIP.LandCalculatorApp.BLL.Service
{
    public class LandAreaCalculator : ILandAreaCalculator
    {
        public int CalculateLandArea(List<Point> points)
        {
            StaticInjector.Logger.Info("result = 0");
            return 0;
        }
    }
}
