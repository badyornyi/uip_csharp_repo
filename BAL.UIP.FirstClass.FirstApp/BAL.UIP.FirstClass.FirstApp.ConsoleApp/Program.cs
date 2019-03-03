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
            
            

            Console.ReadLine();
        }
    }
}
