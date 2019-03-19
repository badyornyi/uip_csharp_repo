using System;

namespace BAL.UIP.FirstClass.FirstApp.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Class 1: Data types

            if (false)
            {
                int rectangleSideA = 30;
                int rectangleSideB = 40;

                int rectangleSquare = rectangleSideA * rectangleSideB;
                int rectanglePerimeter = 2 * rectangleSideA + 2 * rectangleSideB;

                Console.WriteLine(rectangleSquare);
                Console.WriteLine(rectanglePerimeter); 
            }

            if (false)
            {
                int i = 0;
                int i1 = i--;
                Console.WriteLine(i1);
                Console.WriteLine(i);
                int i2 = --i;
                Console.WriteLine(i2);

                Console.ReadLine(); 
            }

            if (false)
            {
                int personAge = 19;

                bool isAlcoholSaleRestricted = personAge < 21;
                Console.WriteLine("Alcohol sale restricted: " + isAlcoholSaleRestricted);
                Console.ReadLine(); 
            }


            // Class 2: if else

            if (false)
            {
                int MINCSHARP = 30;
                int MINENGLISH = 90;
                int MINSOFT = 5;

                int personOneCSharp = 35;
                int personOneEnglish = 95;
                int personOneSoft = 4;
                int personTwoCSharp = 25;
                int personTwoEnglish = 90;
                int personTwoSoft = 6;

                bool isPersonOnePassed = personOneCSharp >= MINCSHARP && (
                    personOneEnglish >= MINENGLISH || personOneSoft >= MINSOFT
                    );

                bool isPersonTwoPassed = personTwoCSharp >= MINCSHARP && (
                    personTwoEnglish >= MINENGLISH || personTwoSoft >= MINSOFT
                    );

                Console.WriteLine("Person 1 passing status is " + isPersonOnePassed);
                Console.WriteLine("Person 2 passing status is " + isPersonTwoPassed);
                Console.ReadLine();


                int currentMark = 4;

                switch (currentMark)
                {
                    case 1:
                    case 2:
                        {
                            Console.WriteLine("Mark is Bad");
                            break;
                        };
                    case 3:
                        {
                            Console.WriteLine("Mark is So-so");
                            break;
                        };
                    case 4:
                        {
                            Console.WriteLine("Mark is Good");
                            break;
                        };
                    case 5:
                        {
                            Console.WriteLine("Excelent");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Current Mark is incorrect");
                            break;
                        }
                };

                Console.ReadLine(); 
            }

            if (false)
            {
                string variableToConvert = Console.ReadLine();
                int variableParsed;
                bool isVariableParceble = Int32.TryParse(variableToConvert, out variableParsed);
                if (isVariableParceble)
                {
                    Console.WriteLine("Variable " + variableToConvert + " was successfully converted to int32: " + variableParsed);
                }
                else
                {
                    Console.WriteLine("Variable " + variableToConvert + " couldn't be converted to int32");
                };
                Console.ReadLine(); 
            }


            // Class 3: Arrays, Cycles

            if (false)
            {
                int[] singleArray = new int[] { 1, 3, 5, 7, 9 };

                for (int i = 0; i < singleArray.Length; i++)
                {
                    //Console.WriteLine("Array element '" + i + "' is: " + singleArray[i]);
                    Console.WriteLine($"Array element '{i}' is: {singleArray[i]}");
                } 
            }

            if (false)
            {
                int[][] jaggedArray = new int[][]
                    {
                new int[] { 1, 3, 5, 7, 9 },
                new int[] { 0, 2, 4, 6 },
                new int[] { 11, 22 }
                    };

                for (int i = 0; i < jaggedArray.Length; i++)
                {
                    for (int j = 0; j < jaggedArray[i].Length; j++)
                    {
                        Console.WriteLine($"Array's array element [{i};{j}] value is: {jaggedArray[i][j]}");
                    }
                }; 
            }

            if (false)
            {
                string[] names = new string[]
                {
                    "Roma",
                    "Maksim",
                    "Sasha"
                };

                foreach (string name in names)
                {
                    if (name[0] == 'R')
                    {
                        continue;
                    }
                    Console.WriteLine(name);
                }

                foreach (string name in names)
                {
                    if (name[0] == 'M')
                    {
                        break;
                    }
                    Console.WriteLine(name);
                }
            }

            if (false)
            {
                string dataFromService = "some-data-for-test";
                Random randomizer = new Random();
                while (dataFromService.Length < 50)
                {
                    Console.WriteLine($"BEFORE: {dataFromService}");
                    int addedNumber = randomizer.Next(0, 10);
                    dataFromService += GetNumberInStringAfterMultiple(addedNumber);
                    Console.WriteLine($"AFTER: {dataFromService}");
                }
            }

            if (false)
            {
                double carPrice = 10594;
                double startSalary = 590;
                double increaseSalaryCoeff = 1.15;
                double currentMoneyAmount = 11000;
                int experienceLevel = 2;
                int numberOfMonthes = 0;

                while (currentMoneyAmount < carPrice)
                {
                    currentMoneyAmount += startSalary;
                    startSalary = CalculateSallary(startSalary, increaseSalaryCoeff, experienceLevel);
                    numberOfMonthes += 1;
                    Console.WriteLine($"Current Month: {numberOfMonthes}");
                    Console.WriteLine($"Current Money Amount: {currentMoneyAmount}");
                    Console.WriteLine($"Next Month Salary: {startSalary}");
                    Console.WriteLine("---------------");
                }

                Console.WriteLine($"Needed number of Monthes to buy car: {numberOfMonthes}");
            }

            // Class 4: Methods

            if (false)
            {
                int first = 10;
                int second = 20;

                int resultSum = CalculateSum(first, second);
                Console.WriteLine(resultSum);
            }

            if (false)
            {
                Console.WriteLine("How many numbers you want to put?");
                int valueFromUser = GetNumberFromUserWithDesiredRange(1, 10);
                int[] arrayValuesFromUser = new int[valueFromUser];
                for (int i = 0; i < valueFromUser ; i++)
                {
                    arrayValuesFromUser[i] = GetNumberFromUserWithDesiredRange(100, 1000);
                }
                PrintArray(arrayValuesFromUser);
            }

            if (true)
            {
                bool isExitReauired = false;
                do
                {
                    PrintMenu();
                    int selectedMenuOption = GetNumberFromUserWithDesiredRange(1, 4);
                    switch (selectedMenuOption)
                    {
                        case 1:
                            FillArray();
                            break;
                        case 2:
                        case 3:
                            DoSomething();
                            break;
                        case 4:
                            Console.Clear();
                            break;
                        case 5:
                            isExitReauired = true;
                            break;
                        default:
                            {
                                break;
                            }
                    }

                } while (isExitReauired);
            }

            Console.ReadLine();
        }

        private static void DoSomething()
        {
            Console.WriteLine("Doing Something");
        }

        static void PrintMenu()
        {
            Console.WriteLine("Menu:");
            string[] menuArray = new string[5]
            {
                "Fill array by numbers",
                "Do something 1",
                "Do something 2",
                "Clear console",
                "Quit"
            };

            PrintArray(menuArray, true, true);

            //Console.WriteLine("[4] Quit");
        }

        // Class 4: Methods

        static int CalculateSum(int a1, int a2)
        {
            int sum = a1 + a2;
            return sum;
        }

        static string GetNumberInStringAfterMultiple(int number)
        {
            int calculationResult = number * 1000;
            return calculationResult.ToString();
        }

        static double CalculateSallary(double startSalary, double increaseSalaryCoeff, int experienceLevel)
        {
            double experienceMultiplier;
            switch (experienceLevel)
            {
                case 1:
                    {
                        experienceMultiplier = 1.05;
                        break;
                    }
                case 2:
                    {
                        experienceMultiplier = 1.1;
                        break;
                    }
                case 3:
                    {
                        experienceMultiplier = 1.2;
                        break;
                    }
                default:
                    {
                        experienceMultiplier = 1;
                        break;
                    }
            }
            startSalary = startSalary * increaseSalaryCoeff * experienceMultiplier;

            return startSalary;
        }

        static int GetNumberFromUserWithDesiredRange(int rangeFrom, int rangeTo)
        {
            int tryParseValid;
            bool isReadyToReturn = false;
            do
            {
                Console.WriteLine($"Please enter number from {rangeFrom} to {rangeTo}:");
                bool tryParseBool = int.TryParse(Console.ReadLine(), out tryParseValid);
                if (!tryParseBool)
                {
                    Console.WriteLine($"The input is not a number. Try again.");
                    continue;
                }

                bool isRangeValid = tryParseValid >= rangeFrom && tryParseValid <= rangeTo;
                if (!isRangeValid)
                {
                    Console.WriteLine($"The number is out of range. Try again.");
                }

                isReadyToReturn = tryParseBool && isRangeValid;
            } while (!isReadyToReturn);
            return tryParseValid;
        }

        static void PrintArray(int[] arrayValuesFromUser)
        {
            foreach (int eachValue in arrayValuesFromUser)
            {
                Console.WriteLine($"{eachValue}");
            }
        }

        static void PrintArray(string[] array, bool isPrintIndex, bool isWriteOnNewLine)
        {
            //foreach (string eachValue in arrayValuesFromUser)
            for (int i = 0; i < array.Length; i++)
            {
                string printText = isPrintIndex ? $"[{i+1}]{array[i]}" : $"{array[i]}";

                if (isWriteOnNewLine)
                {
                    Console.WriteLine($"{printText}");
                }
                else
                {
                    Console.Write($"{printText}");
                }
            }
        }

        static void FillArray()
        {
            Console.WriteLine("How many numbers you want to put?");
            int valueFromUser = GetNumberFromUserWithDesiredRange(1, 10);
            int[] arrayValuesFromUser = new int[valueFromUser];
            for (int i = 0; i < valueFromUser; i++)
            {
                arrayValuesFromUser[i] = GetNumberFromUserWithDesiredRange(100, 1000);
            }
            PrintArray(arrayValuesFromUser);
        }
    }
}
