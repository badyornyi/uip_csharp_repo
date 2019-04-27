using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.UIP.LandCalculatorApp.Shared.Interfaces
{
    public interface ILandAreaCalculator
    {
        int CalculateLandArea(List<Point> points);
    }
}
