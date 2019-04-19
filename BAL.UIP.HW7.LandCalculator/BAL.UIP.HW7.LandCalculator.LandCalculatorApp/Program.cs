using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.UIP.HW7.LandCalculator.LandCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int pointsCount = PointsCount.GetPointsCount();

            Console.Write("Please, describe, how many points (3 or more) you will enter: ");
            int pointsCount;
            while (!(Int32.TryParse(Console.ReadLine(), out pointsCount)) || pointsCount <= 2)
            {
                Console.Write("Incorrect points number value. Please, enter positive integer value: ");
            }
            Console.WriteLine($"Points count: {pointsCount}");

            // 1) определяют координаты X, Y необходимого количества k точек, принадлежащих границе участка;
            List<Point> points = new List<Point>() { };
            for (int i = 0; i < pointsCount; i++)
            {
                Console.Write($"Please, enter X coordinate for {i + 1} point: ");
                int x = Int32.Parse(Console.ReadLine());
                Console.Write($"Please, enter Y coordinate for {i + 1} point: ");
                int y = Int32.Parse(Console.ReadLine());
                Point point = new Point(x, y);
                points.Add(point);
            }

            foreach (Point point in points)
            {
                Console.WriteLine($"[{point.XPoint};{point.YPoint}]");
            }

            // 2) вычисляют сумму Sum (Yi * (Xi-1 – Xi+1)), где i in [1,2,3...k];
            int sumY = 0;
            for (int i = 0; i < pointsCount; i++)
            {
                if (i == 0)
                {
                    sumY = sumY + (points[i].YPoint * (points[pointsCount - 1].XPoint - points[i + 1].XPoint));
                }
                else if (i == pointsCount - 1)
                {
                    sumY = sumY + (points[i].YPoint * (points[i - 1].XPoint - points[0].XPoint));
                }
                else
                {
                    sumY = sumY + (points[i].YPoint * (points[i - 1].XPoint - points[i + 1].XPoint));
                }
            }

            // 3) площадь участка определяют как половину найденной с
            //sumY = Math.Abs(sumY / 2);
            sumY = sumY / 2;

            Console.WriteLine($"Sum = {sumY}");


            int sumX = 0;
            for (int i = 0; i < pointsCount; i++)
            {
                if (i == 0)
                {
                    sumX = sumX + (points[i].XPoint * (points[i + 1].YPoint - points[pointsCount - 1].YPoint));
                }
                else if (i == pointsCount - 1)
                {
                    sumX = sumX + (points[i].XPoint * (points[0].YPoint - points[i - 1].YPoint));
                }
                else
                {
                    sumX = sumX + (points[i].XPoint * (points[i + 1].YPoint - points[i - 1].YPoint));
                }
            }

            // 3) площадь участка определяют как половину найденной с
            //sumX = Math.Abs(sumX / 2);
            sumX = sumX / 2;

            Console.WriteLine($"Sum = {sumX}");

            //private long CalculateArea(List<Point> points, bool isAltAppr)
            //{
            //    long landArea = 0;
            //    for (int i = 0; i < points.Count; i++)
            //    {
            //        int nextIndex = (i == points.Count - 1) ? 0 : i + 1;
            //        int prevIndex = (i == 0) ? points.Count - 1 : i - 1;
            //        long par1 = isAltAppr ? points[i].X : points[i].Y;
            //        long par2_1 = isAltAppr ? points[nextIndex].Y : points[prevIndex].X;
            //        long par2_2 = isAltAppr ? points[prevIndex].Y : points[nextIndex].X;
            //        long tempLandArea = landArea;
            //        landArea += par1 * (par2_1 - par2_2);
            //    }
            //    long result = (long)Math.Abs(landArea / 2);
            //    return result;
            //}

            Console.ReadLine();
        }
    }

    public class Point
    {
        public int XPoint { get; set; }
        public int YPoint { get; set; }

        public Point(int xPoint, int yPoint)
        {
            this.XPoint = xPoint;
            this.YPoint = yPoint;
        }
    }

    public class PointsCount
    {
        public GetPointsCount
    }
}
