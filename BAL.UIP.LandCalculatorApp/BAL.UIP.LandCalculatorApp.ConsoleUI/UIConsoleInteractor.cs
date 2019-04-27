using BAL.UIP.LandCalculatorApp.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.UIP.LandCalculatorApp.ConsoleUI
{
    public class UIConsoleInteractor
    {
        private ILandAreaCalculator LandAreaCalculator;

        public UIConsoleInteractor(ILandAreaCalculator landAreaCalculator)
        {
            LandAreaCalculator = landAreaCalculator;
        }

        internal void Start()
        {
            List<Point> points = GetPoints();

            int landArea = LandAreaCalculator.CalculateLandArea(points);

            Console.WriteLine($"Result = {landArea}");
        }

        private List<Point> GetPoints()
        {
            return null;
        }
    }
}
