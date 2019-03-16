using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.UIP.HW1.VariablesTypesTask1.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1. Rectangle square; Rectangle perimeter
            int rectangleSideA = 30;
            int rectangleSideB = 50;
            
            int rectangleSquare = rectangleSideA * rectangleSideB;
            int rectanglePerimeter = 2 * (rectangleSideA + rectangleSideB);

            Console.WriteLine("Task 1");
            Console.WriteLine("Rectangle square: " + rectangleSquare);
            Console.WriteLine("Rectangle perimeter: " + rectanglePerimeter);
            Console.WriteLine("\n");

            // Task 2. Circle length; Circle square
            double circleRadius = 5;
            double pi = 3.14;
            
            double circleLength = 2 * pi * circleRadius;
            double circleSquare = pi * circleRadius * circleRadius;
            //circleSquare = pi * Math.Pow(circleRadius, 2);

            Console.WriteLine("Task 2");
            Console.WriteLine("Circle length: " + circleLength);
            Console.WriteLine("Circle square: " + circleSquare);
            Console.WriteLine("\n");

            // Task 3. Arithmetical mean
            double numberA = 192;
            double numberB = 439;

            double arithmeticalMean = (numberA + numberB) / 2;

            Console.WriteLine("Task 3");
            Console.WriteLine("Arithmetical mean of " + numberA + " and " + numberB + ": " + arithmeticalMean);
            Console.WriteLine("\n");

            // Task 4. Geometric mean
            double nonNegativeNumberA = 9;
            double nonNegativeNumberB = 16;
            
            double geometricMean = Math.Sqrt(nonNegativeNumberA * nonNegativeNumberB);

            Console.WriteLine("Task 4");
            Console.WriteLine("Geometric mean of " + nonNegativeNumberA + " and " + nonNegativeNumberB + ": " + geometricMean);
            Console.WriteLine("\n");

            // Task 5. Distance between two points
            int point1 = -9;
            int point2 = 11;

            int distanceBetweenPoints = point2 - point1;

            Console.WriteLine("Task 5");
            Console.WriteLine("Distance between points " + point1 + " and " + point2 + ": " + distanceBetweenPoints);
            Console.WriteLine("\n");

            // Task 6. Graph Rectangle square; Graph Rectangle perimeter
            int coordinateX1 = 5;
            int coordinateY1 = 3;
            int coordinateX2 = 10;
            int coordinateY2 = 6;

            int graphRectangleSideA = coordinateX2 - coordinateX1;
            int graphRectangleSideB = coordinateY2 - coordinateY1;
            int graphRectangleSquare = graphRectangleSideA * graphRectangleSideB;
            int graphRectanglePerimeter = 2 * (graphRectangleSideA + graphRectangleSideB);

            Console.WriteLine("Task 6");
            Console.WriteLine("Graph Rectangle square: " + graphRectangleSquare);
            Console.WriteLine("Graph Rectangle perimeter: " + graphRectanglePerimeter);
            Console.WriteLine("\n");
            
            // Task 7. Values moving
            int variableA = 10;
            int variableB = 20;
            int variableC = 30;
            
            Console.WriteLine("Task 6");
            Console.WriteLine("Initial variables values:\nA = " + variableA + ", B = " + variableB + " , C = " + variableC);

            int tempVariable = variableC;
            variableC = variableB;
            variableB = variableA;
            variableA = tempVariable;

            Console.WriteLine("New variables values:\nA = " + variableA + ", B = " + variableB + " , C = " + variableC);
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
