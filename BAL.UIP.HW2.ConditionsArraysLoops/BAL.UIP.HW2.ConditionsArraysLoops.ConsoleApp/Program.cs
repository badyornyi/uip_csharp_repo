using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.UIP.HW2.ConditionsArraysLoops.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random();

            // Task 1.
            if (true)
            {
                int taskOneVariableA = randomizer.Next(-50, 50);

                bool isTaskOneVariableAPositive = taskOneVariableA > 0;

                Console.WriteLine("Task 1");
                Console.WriteLine($"Var A = {taskOneVariableA}\nIs it positive? {isTaskOneVariableAPositive}");
                Console.WriteLine("\n"); 
            }

            // Task 2.
            if (true)
            {
                int taskTwoVariableA = randomizer.Next(-50, 50);

                int taskTwoModulo = taskTwoVariableA % 2;

                bool isTaskTwoVariableAOdd = taskTwoModulo != 0;

                Console.WriteLine("Task 2");
                Console.WriteLine($"Var A = {taskTwoVariableA}\nIs it odd? {isTaskTwoVariableAOdd}");
                Console.WriteLine("\n"); 
            }

            // Task 3.
            if (true)
            {
                int taskThreeVariableA = randomizer.Next(-50, 50);
                int taskThreeVariableB = randomizer.Next(-50, 50);
                int taskThreeVariableC = randomizer.Next(-50, 50);

                bool isALessBLessC = (taskThreeVariableA < taskThreeVariableB) && (taskThreeVariableB < taskThreeVariableC);

                Console.WriteLine("Task 3");
                Console.WriteLine(
                    $"Var A = {taskThreeVariableA}\n" +
                    $"Var B = {taskThreeVariableB}\n" +
                    $"Var C = {taskThreeVariableC}\n" +
                    $"Is A < B < C? {isALessBLessC}");
                Console.WriteLine("\n"); 
            }

            // Task 4.
            if (true)
            {
                int taskFourVariableA = randomizer.Next(-50, 50);
                int taskFourVariableB = randomizer.Next(-50, 50);
                int taskFourVariableC = randomizer.Next(-50, 50);

                bool isAnyNumberPositive = (taskFourVariableA > 0) || (taskFourVariableB > 0) || (taskFourVariableC > 0);

                Console.WriteLine("Task 4");
                Console.WriteLine(
                    $"Var A = {taskFourVariableA}\n" +
                    $"Var B = {taskFourVariableB}\n" +
                    $"Var C = {taskFourVariableC}\n" +
                    $"Is any of A, B, C is positive? {isAnyNumberPositive}");
                Console.WriteLine("\n"); 
            }

            // Task 5.
            if (true)
            {
                int taskFiveVariableA = randomizer.Next(-50, 50);
                int taskFiveVariableB = randomizer.Next(-50, 50);
                int taskFiveVariableC = randomizer.Next(-50, 50);
                bool isOnlyOneNumberPositive = false;

                isOnlyOneNumberPositive = (taskFiveVariableA > 0) ^ (taskFiveVariableB > 0) ^ (taskFiveVariableC > 0);

                Console.WriteLine("Task 5");
                Console.WriteLine(
                    $"Var A = {taskFiveVariableA}\n" +
                    $"Var B = {taskFiveVariableB}\n" +
                    $"Var C = {taskFiveVariableC}\n" +
                    $"Is only one of A, B, C is positive? {isOnlyOneNumberPositive}");
                Console.WriteLine("\n"); 
            }

            // Task 6.
            if (true)
            {
                int taskSixVariableA = randomizer.Next(1, 1900);

                bool istaskSixVariableAOdd = taskSixVariableA % 2 == 1;
                bool istaskSixVariableAThreeDigit = taskSixVariableA >= 100 && taskSixVariableA <= 999;
                bool isNumberOddThreeDigit = istaskSixVariableAOdd && istaskSixVariableAThreeDigit;

                Console.WriteLine("Task 6");
                Console.WriteLine($"Var A = {taskSixVariableA}\n" +
                    $"Is A is odd three digits number? {isNumberOddThreeDigit}");
                Console.WriteLine("\n"); 
            }

            // Task 7.
            if (true)
            {
                int pointCoordinateX = randomizer.Next(0, 100);
                int pointCoordinateY = randomizer.Next(0, 100);
                int rectangleTopLeftX1 = randomizer.Next(0, 90);
                int rectangleTopLeftY1 = randomizer.Next(10, 100);
                int rectangleBottomRightX2 = randomizer.Next(10, 100);
                int rectangleBottomRightY2 = randomizer.Next(0, 90);

                while (rectangleBottomRightX2 <= rectangleTopLeftX1)
                {
                    rectangleBottomRightX2 = randomizer.Next(10, 100);
                }

                while (rectangleBottomRightY2 >= rectangleTopLeftY1)
                {
                    rectangleBottomRightY2 = randomizer.Next(0, 90);
                }

                bool isPointInXRange = (pointCoordinateX >= rectangleTopLeftX1) && (pointCoordinateX <= rectangleBottomRightX2);
                bool isPointInYRange = (pointCoordinateY >= rectangleBottomRightY2) && (pointCoordinateY <= rectangleTopLeftY1);

                bool isCoordinateWithinRectangle = isPointInXRange && isPointInYRange;

                Console.WriteLine("Task 7");
                Console.WriteLine(
                    $"Rectangle top-left coordinates: [{rectangleTopLeftX1}; {rectangleTopLeftY1}]\n" +
                    $"Rectangle bottom-right coordinates: [{rectangleBottomRightX2}; {rectangleBottomRightY2}]\n" +
                    $"Point coordinatess: [{pointCoordinateX}; {pointCoordinateY}]\n" +
                    $"Is coordinate within rectangle? {isCoordinateWithinRectangle}");
                Console.WriteLine("\n"); 
            }

            // Task 8.
            if (true)
            {
                int triangleSideA = randomizer.Next(1, 50);
                int triangleSideB = randomizer.Next(1, 50);
                int triangleSideC = randomizer.Next(1, 50);
                bool isTriangleExists = false;

                bool isABSumLessC = triangleSideA + triangleSideB > triangleSideC;
                bool isBCSumLessA = triangleSideB + triangleSideC > triangleSideA;
                bool isACSumLessB = triangleSideA + triangleSideC > triangleSideB;

                isTriangleExists = isABSumLessC && isBCSumLessA && isACSumLessB;

                Console.WriteLine("Task 8");
                Console.WriteLine(
                    $"Side A = {triangleSideA}\n" +
                    $"Side B = {triangleSideB}\n" +
                    $"Side C = {triangleSideC}\n" +
                    $"Is triangle with this sides exists? {isTriangleExists}");
                Console.WriteLine("\n"); 
            }

            // Task 9.
            if (true)
            {
                int chessFieldCoordinateX = randomizer.Next(1, 8);
                int chessFieldCoordinateY = randomizer.Next(1, 8);

                bool isFieldWhite = ((chessFieldCoordinateX + chessFieldCoordinateY) % 2) == 1;

                Console.WriteLine("Task 9");
                Console.WriteLine($"Chess field coordinates: [{chessFieldCoordinateX}; {chessFieldCoordinateY}]\n" +
                    $"Is this chess field White? {isFieldWhite}");
                Console.WriteLine("\n"); 
            }

            // Task 10.
            if (true)
            {
                int chessFieldCoordinateX1 = randomizer.Next(1, 8);
                int chessFieldCoordinateY1 = randomizer.Next(1, 8);
                int chessFieldCoordinateX2 = randomizer.Next(1, 8);
                int chessFieldCoordinateY2 = randomizer.Next(1, 8);

                bool isPossibleHorisontalMove = chessFieldCoordinateY1 == chessFieldCoordinateY2;
                bool isPossibleVerticalMove = chessFieldCoordinateX1 == chessFieldCoordinateX2;
                bool isPossibleDiagonalMove = Math.Abs(chessFieldCoordinateX2 - chessFieldCoordinateX1) == Math.Abs(chessFieldCoordinateY2 - chessFieldCoordinateY1);

                bool isQueenCanMove = isPossibleHorisontalMove || isPossibleVerticalMove || isPossibleDiagonalMove;

                Console.WriteLine("Task 10");
                Console.WriteLine(
                    $"Chess field N1 coordinates: [{chessFieldCoordinateX1}; {chessFieldCoordinateY1}]\n" +
                    $"Chess field N2 coordinates: [{chessFieldCoordinateX2}; {chessFieldCoordinateY2}]\n" +
                    $"Is Queen can move from field N1 to field N2? {isQueenCanMove}");
                Console.WriteLine("\n"); 
            }

            // Task 11.
            if (true)
            {
                int taskElevenVariableA = randomizer.Next(-50, 50);
                int taskElevenVariableB = randomizer.Next(-50, 50);

                Console.WriteLine("Task 11");
                Console.WriteLine($"Variable A before transition: {taskElevenVariableA}");
                Console.WriteLine($"Variable B before transition: {taskElevenVariableB}");

                taskElevenVariableA = taskElevenVariableA + taskElevenVariableB;
                taskElevenVariableB = taskElevenVariableA - taskElevenVariableB;
                taskElevenVariableA = taskElevenVariableA - taskElevenVariableB;

                Console.WriteLine($"Variable A after transition: {taskElevenVariableA}");
                Console.WriteLine($"Variable B after transition: {taskElevenVariableB}");
                Console.WriteLine("\n"); 
            }

            // Task 12.
            if (true)
            {
                int currentDay = randomizer.Next(1, 8);

                Console.WriteLine("Task 12");
                Console.WriteLine("Currend day is:");
                switch (currentDay)
                {
                    case 1:
                        {
                            Console.WriteLine("Monday");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Tuesday");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Wednesday");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Thursday");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Friday");
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Saturday");
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Sunday");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Unknown day number");
                            break;
                        }
                }
                Console.WriteLine("\n"); 
            }

            // Task 13.
            if (true)
            {
                int mark = randomizer.Next(0, 6);

                Console.WriteLine("Task 13");
                Console.WriteLine($"Mark {mark} deconding:");
                switch (mark)
                {
                    case 1:
                    case 2:
                        {
                            Console.WriteLine("Unsatisfactory");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Satisfactory");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Good");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Excelent");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Error");
                            break;
                        }
                }
                Console.WriteLine("\n"); 
            }

            // Task 14.
            if (true)
            {
                int lenthUnit = randomizer.Next(1, 5);
                double lengthInUnits = randomizer.Next(0, 1000);
                double unitMultiplier;

                switch (lenthUnit)
                {
                    case 1:
                        {
                            unitMultiplier = 0.1;
                            break;
                        }
                    case 2:
                        {
                            unitMultiplier = 1000;
                            break;
                        }
                    case 3:
                        {
                            unitMultiplier = 1;
                            break;
                        }
                    case 4:
                        {
                            unitMultiplier = 0.001;
                            break;
                        }
                    case 5:
                        {
                            unitMultiplier = 0.01;
                            break;
                        }
                    default:
                        {
                            unitMultiplier = 0;
                            Console.WriteLine("Unknown lenth unit");
                            break;
                        }
                }

                double segmentLength = unitMultiplier * lengthInUnits;

                Console.WriteLine("Task 14");
                Console.WriteLine($"Unit Multiplier: {unitMultiplier}");
                Console.WriteLine($"Length in units: {lengthInUnits}");
                Console.WriteLine($"Segment Length: {segmentLength} meters");
                Console.WriteLine("\n"); 
            }

            // Task 15.
            if (true)
            {
                int numberToWrite = randomizer.Next(1, 99);

                Console.WriteLine("Task 15");
                Console.WriteLine($"Number: {numberToWrite}");

                if ((numberToWrite < 10) || numberToWrite > 19)
                {
                    string firstDigit = "";
                    string secondDigit = "";
                    string digits = numberToWrite.ToString();

                    if (digits.Length == 1)
                    {
                        digits = "0" + digits;
                    }

                    char[] digitsArray = digits.ToCharArray();

                    switch (digitsArray[0])
                    {
                        case '2':
                            {
                                firstDigit = "twenty ";
                                break;
                            }
                        case '3':
                            {
                                firstDigit = "thirty ";
                                break;
                            }
                        case '4':
                            {
                                firstDigit = "forty ";
                                break;
                            }
                        case '5':
                            {
                                firstDigit = "fifty ";
                                break;
                            }
                        case '6':
                            {
                                firstDigit = "sixty ";
                                break;
                            }
                        case '7':
                            {
                                firstDigit = "seventy ";
                                break;
                            }
                        case '8':
                            {
                                firstDigit = "eighty ";
                                break;
                            }
                        case '9':
                            {
                                firstDigit = "ninety ";
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }

                    switch (digitsArray[1])
                    {
                        case '1':
                            {
                                secondDigit = "one";
                                break;
                            }
                        case '2':
                            {
                                secondDigit = "two";
                                break;
                            }
                        case '3':
                            {
                                secondDigit = "three";
                                break;
                            }
                        case '4':
                            {
                                secondDigit = "four";
                                break;
                            }
                        case '5':
                            {
                                secondDigit = "five";
                                break;
                            }
                        case '6':
                            {
                                secondDigit = "six";
                                break;
                            }
                        case '7':
                            {
                                secondDigit = "seven";
                                break;
                            }
                        case '8':
                            {
                                secondDigit = "eight";
                                break;
                            }
                        case '9':
                            {
                                secondDigit = "nine";
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }

                    Console.WriteLine($"Text number: {firstDigit}{secondDigit}");
                    Console.WriteLine("\n");
                }
                else
                {
                    switch (numberToWrite)
                    {
                        case 10:
                            {
                                Console.WriteLine($"Text number: ten");
                                break;
                            }
                        case 11:
                            {
                                Console.WriteLine($"Text number: eleven");
                                break;
                            }
                        case 12:
                            {
                                Console.WriteLine($"Text number: twelve");
                                break;
                            }
                        case 13:
                            {
                                Console.WriteLine($"Text number: thirteen");
                                break;
                            }
                        case 14:
                            {
                                Console.WriteLine($"Text number: fourteen");
                                break;
                            }
                        case 15:
                            {
                                Console.WriteLine($"Text number: fifteen");
                                break;
                            }
                        case 16:
                            {
                                Console.WriteLine($"Text number: sixteen");
                                break;
                            }
                        case 17:
                            {
                                Console.WriteLine($"Text number: seventeen");
                                break;
                            }
                        case 18:
                            {
                                Console.WriteLine($"Text number: eighteen");
                                break;
                            }
                        case 19:
                            {
                                Console.WriteLine($"Text number: nineteen");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine($"Text number: number is out of range");
                                break;
                            }
                    }
                    Console.WriteLine("\n");
                } 
            }

            // Task 16.
            if (true)
            {
                int firstArrayCount = randomizer.Next(1, 20);
                int secondArrayCount = randomizer.Next(1, 20);
                int[] firstArray = new int[firstArrayCount];
                int[] secondArray = new int[secondArrayCount];

                for (int i = 0; i < firstArrayCount; i++)
                {
                    firstArray[i] = randomizer.Next(-20, 20);
                }

                for (int i = 0; i < secondArrayCount; i++)
                {
                    secondArray[i] = randomizer.Next(-20, 20);
                }

                int resultArrayCount = firstArrayCount >= secondArrayCount ? firstArrayCount : secondArrayCount;
                int[] resultArray = new int[resultArrayCount];

                int lessArrayCount = firstArrayCount >= secondArrayCount ? secondArrayCount : firstArrayCount;
                for (int i = 0; i < lessArrayCount; i++)
                {
                    resultArray[i] = firstArray[i] >= secondArray[i] ? firstArray[i] : secondArray[i];
                }
                for (int i = lessArrayCount; i < resultArrayCount; i++)
                {
                    resultArray[i] = firstArrayCount >= secondArrayCount ? firstArray[i] : secondArray[i];
                }

                Console.WriteLine("Task 16");
                for (int i = 0; i < resultArrayCount; i++)
                {
                    Console.WriteLine($"Result Array element {i}: {resultArray[i]}");
                }
                Console.WriteLine("\n"); 
            }

            Console.ReadLine();
        }
    }
}
