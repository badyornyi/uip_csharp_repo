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
            int rectangleSquare;
            int rectanglePerimeter;

            rectangleSquare = rectangleSideA * rectangleSideB;
            rectanglePerimeter = 2 * (rectangleSideA + rectangleSideB);

            Console.WriteLine("Task 1");
            Console.WriteLine("Rectangle square: " + rectangleSquare);
            Console.WriteLine("Rectangle perimeter: " + rectanglePerimeter);
            Console.WriteLine("\n");

            // Task 2. Circle length; Circle square
            double circleRadius = 5;
            double pi = 3.14;
            double circleLength;
            double circleSquare;

            circleLength = 2 * pi * circleRadius;
            circleSquare = pi * circleRadius * circleRadius;
            //circleSquare = pi * Math.Pow(circleRadius, 2);

            Console.WriteLine("Task 2");
            Console.WriteLine("Circle length: " + circleLength);
            Console.WriteLine("Circle square: " + circleSquare);
            Console.WriteLine("\n");

            // Task 3. Arithmetical mean
            double numberA = 192;
            double numberB = 439;
            double arithmeticalMean;

            arithmeticalMean = (numberA + numberB) / 2;

            Console.WriteLine("Task 3");
            Console.WriteLine("Arithmetical mean of " + numberA + " and " + numberB + ": " + arithmeticalMean);
            Console.WriteLine("\n");

            // Task 4. Geometric mean
            double non_negative_numberA = 9;
            double non_negative_numberB = 16;
            double geometricMean;

            geometricMean = Math.Sqrt(non_negative_numberA * non_negative_numberB);

            Console.WriteLine("Task 4");
            Console.WriteLine("Geometric mean of " + non_negative_numberA + " and " + non_negative_numberB + ": " + geometricMean);
            Console.WriteLine("\n");

            // Task 5. Distance between two points
            int point1 = -9;
            int point2 = 11;
            int distanceBetweenPoints;

            distanceBetweenPoints = point2 - point1;

            Console.WriteLine("Task 5");
            Console.WriteLine("Distance between points " + point1 + " and " + point2 + ": " + distanceBetweenPoints);
            Console.WriteLine("\n");

            // Task 6. Graph Rectangle square; Graph Rectangle perimeter
            int coordinateX1 = 5;
            int coordinateY1 = 3;
            int coordinateX2 = 10;
            int coordinateY2 = 6;
            int graphRectangleSideA;
            int graphRectangleSideB;
            int graphRectangleSquare;
            int graphRectanglePerimeter;

            graphRectangleSideA = coordinateX2 - coordinateX1;
            graphRectangleSideB = coordinateY2 - coordinateY1;
            graphRectangleSquare = graphRectangleSideA * graphRectangleSideB;
            graphRectanglePerimeter = 2 * (graphRectangleSideA + graphRectangleSideB);

            Console.WriteLine("Task 6");
            Console.WriteLine("Graph Rectangle square: " + graphRectangleSquare);
            Console.WriteLine("Graph Rectangle perimeter: " + graphRectanglePerimeter);
            Console.WriteLine("\n");
            
            // Task 7. Values moving
            int variableA = 10;
            int variableB = 20;
            int variableC = 30;
            int tempVariable;

            Console.WriteLine("Task 6");
            Console.WriteLine("Initial variables values:\nA = " + variableA + ", B = " + variableB + " , C = " + variableC);

            tempVariable = variableC;
            variableC = variableB;
            variableB = variableA;
            variableA = tempVariable;

            Console.WriteLine("New variables values:\nA = " + variableA + ", B = " + variableB + " , C = " + variableC);
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
