﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.UIP.HW3.ArraysLoopsConditionalsMethods.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random();

            // Task 1. Даны два целых числа A и B (A < B).
            // Вывести в порядке возрастания все целые числа,
            // расположенные между A и B (включая сами числа A и B),
            // а также количество N этих чисел.
            if(true)
            {
                Console.WriteLine("Task 1.");
                int taskOneVariableOne = randomizer.Next(-50, 49);
                int taskOneVariableTwo = GetBiggerSecondNumber(taskOneVariableOne);
                
                int taskOneCountOfNumbers = GetCountOfNumbersInRangeIncluding(taskOneVariableOne, taskOneVariableTwo);

                int[] taskOneAllNumbersInRange = GetAllNumbersInRangeIncreasing(taskOneCountOfNumbers, taskOneVariableOne);

                Console.WriteLine($"Number of numbers between {taskOneVariableOne} and {taskOneVariableTwo} (including): {taskOneCountOfNumbers}");
                Console.Write($"Numbers between {taskOneVariableOne} and {taskOneVariableTwo} (increasing): ");
                foreach (int number in taskOneAllNumbersInRange)
                {
                    string result = (number != taskOneVariableTwo) ? $"{number}, " : $"{number}";
                    Console.Write(result);
                }
                Console.WriteLine("\n\n");
            }


            // Task 2. Даны два целых числа A и B (A < B).
            // Вывести в порядке убывания все целые числа,
            // расположенные между A и B (не включая числа A и B),
            // а также количество N этих чисел.
            if (true)
            {
                Console.WriteLine("Task 2.");
                int taskTwoVariableOne = randomizer.Next(-50, 49);
                int taskTwoVariableTwo = GetBiggerSecondNumber(taskTwoVariableOne);

                int taskTwoCountOfNumbers = GetCountOfNumbersInRangeExcluding(taskTwoVariableOne, taskTwoVariableTwo);

                int[] taskTwoAllNumbersInRange = GetAllNumbersInRangeDecreasing(taskTwoCountOfNumbers, taskTwoVariableTwo);

                Console.WriteLine($"Number of numbers between {taskTwoVariableOne} and {taskTwoVariableTwo} (excluding): {taskTwoCountOfNumbers}");
                if (taskTwoCountOfNumbers != 0)
                {
                    Console.Write($"Numbers between {taskTwoVariableOne} and {taskTwoVariableTwo} (decreasing): ");
                    int taskTwoVariableOneNext = taskTwoVariableOne + 1;
                    foreach (int number in taskTwoAllNumbersInRange)
                    {
                        string result = (number != taskTwoVariableOneNext) ? $"{number}, " : $"{number}";
                        Console.Write(result);
                    }
                }
                Console.WriteLine("\n\n");
            }


            // Task 3. Начальный вклад в банке равен $1000.
            // Через каждый месяц размер вклада увеличивается на P процентов от имеющейся суммы (P — вещественное число, 0 < P < 25).
            // По данному P определить, через сколько месяцев размер вклада превысит $1100,
            // и вывести найденное количество месяцев K (целое число)
            // и итоговый размер вклада S (вещественное число).
            if (true)
            {
                Console.WriteLine("Task 3.");
                int startMoneyAmount = 1000;
                double increasingValue = randomizer.Next(1, 25);
                double monthlyPercents = increasingValue / 100 + 1.0;
                int totalMonthes = 0;
                double totalMoneyAmount = startMoneyAmount;

                while (totalMoneyAmount <= 1100)
                {
                    totalMoneyAmount = totalMoneyAmount * monthlyPercents;
                    totalMonthes++;
                }

                Console.WriteLine($"Total monthes K: {totalMonthes}");
                Console.Write($"Total money amount S: {totalMoneyAmount}");
                Console.WriteLine("\n\n");
            }


            // Task 4. Дано целое число N (> 0).
            // Сформировать и вывести целочисленный массив размера N,
            // содержащий N первых положительных нечетных чисел: 1, 3, 5, … .
            if (true)
            {
                Console.WriteLine("Task 4.");
                int taskFourVariableN = randomizer.Next(1, 50);
                
                int[] taskFourOddNumbers = GetNFirstPositiveOddNumbers(taskFourVariableN);
                
                Console.Write($"{taskFourVariableN} first positive odd numbers are: ");
                int taskFourOddNumbersLastIndex = taskFourOddNumbers.Length - 1;
                for (int i = 0; i < taskFourOddNumbers.Length; i++)
                {
                    string result = (i != taskFourOddNumbersLastIndex) ? $"{taskFourOddNumbers[i]}, " : $"{taskFourOddNumbers[i]}";
                    Console.Write(result);
                }
                Console.WriteLine("\n\n");
            }


            // Task 5. Дан массив размера N.
            // Вывести его элементы в обратном порядке.
            if (true)
            {
                Console.WriteLine("Task 5.");
                int taskFiveVariableN = randomizer.Next(1, 50);
                
                int[] taskFiveRandomNumbersArray = GetRandomNumbersArray(taskFiveVariableN, -50, 50);

                Console.Write($"{taskFiveVariableN} array elements in reversal view are: ");
                for (int i = taskFiveRandomNumbersArray.Length - 1; i >= 0; i--)
                {
                    string result = (i != 0) ? $"{taskFiveRandomNumbersArray[i]}, " : $"{taskFiveRandomNumbersArray[i]}";
                    Console.Write(result);
                }
                Console.WriteLine("\n\n");
            }


            // Task 6. Дан целочисленный массив размера N.
            // Вывести вначале все содержащиеся в данном массиве четные числа в порядке возрастания их индексов,
            // а затем — все нечетные числа в порядке убывания их индексов.
            // Также вывести количество четных и нечетных членов массива.
            if (true)
            {
                Console.WriteLine("Task 6.");
                int taskSixVariableN = randomizer.Next(1, 50);
                int evenNumbersQuantity = 0;
                int oddNumbersQuantity = 0;

                int[] taskSixRandomNumbersArray = GetRandomNumbersArray(taskSixVariableN, -50, 50);

                Console.WriteLine($"Total size of Array: {taskSixRandomNumbersArray.Length}\n");
                Console.WriteLine($"Even numbers from Array in incremental order of indexes: ");
                int taskSixRandomNumbersArrayLastIndex = taskSixRandomNumbersArray.Length - 1;
                for (int i = 0; i < taskSixRandomNumbersArray.Length; i++)
                {
                    if (taskSixRandomNumbersArray[i] % 2 == 0)
                    {
                        string result = (i != taskSixRandomNumbersArrayLastIndex) ? $"{taskSixRandomNumbersArray[i]}, " : $"{taskSixRandomNumbersArray[i]}";
                        Console.Write(result);
                        evenNumbersQuantity++;
                    }
                }
                Console.WriteLine($"\nEven numbers quantity in Array: {evenNumbersQuantity}\n");
                Console.WriteLine($"Odd numbers from Array in decremental order of indexes: ");
                for (int i = taskSixRandomNumbersArrayLastIndex; i >=0; i--)
                {
                    if (taskSixRandomNumbersArray[i] % 2 != 0)
                    {
                        string result = (i != 0) ? $"{taskSixRandomNumbersArray[i]}, " : $"{taskSixRandomNumbersArray[i]}";
                        Console.Write(result);
                        oddNumbersQuantity++;
                    }
                }
                Console.WriteLine($"\nOdd numbers quantity in Array: {oddNumbersQuantity}");
                Console.WriteLine("\n");
            }


            // Task 7. Дан массив A размера N (N — четное число).
            // Вывести его элементы с четными номерами в порядке возрастания номеров: A2, A4, A6, …, AN.
            // Условный оператор не использовать.
            if (true)
            {
                Console.WriteLine("Task 7.");
                int taskSevenEvenVariableN = randomizer.Next(2, 50);
                while (taskSevenEvenVariableN % 2 != 0)
                {
                    taskSevenEvenVariableN = randomizer.Next(2, 50);
                }
                
                int[] taskSevenRandomNumbersArray = GetRandomNumbersArray(taskSevenEvenVariableN, -50, 50);

                Console.WriteLine($"Total size of Array: {taskSevenRandomNumbersArray.Length}\n");
                Console.WriteLine($"Numbers with even index numbers from Array in incremental order of indexes: ");
                for (int i = 1; i < taskSevenRandomNumbersArray.Length; i += 2)
                {
                    Console.Write($"{taskSevenRandomNumbersArray[i]}, ");
                }
                Console.WriteLine("\n");
            }

            /* ========== End of Part 1 Main ========== */
            /* ========== Start of Part 2 Main ======== */

            // Task 8. Дан целочисленный массив размера N.
            // Найти количество различных элементов в данном массиве.
            //if (false)
            //{
            //    Console.WriteLine("Task 8.");
            //    int taskElevenVariableN = randomizer.Next(10, 10);
            //    int[] taskElevenRandomNumbersArray = new int[taskElevenVariableN];
            //    int taskElevenQuantityOfDifferentValues = 0;

            //    taskElevenRandomNumbersArray = GetRandomNumbersArray(taskElevenVariableN, 0, 10);

            //    for (int i = 0; i < taskElevenRandomNumbersArray.Length; i++)
            //    {
            //        Console.Write($"{taskElevenRandomNumbersArray[i]}, ");
            //    }

            //    for (int i = 0; i < taskElevenRandomNumbersArray.Length; i++)
            //    {
            //        for (int j = 0; j < taskElevenRandomNumbersArray.Length; j++)
            //        {
            //            if (i < j)
            //            {
            //                if (taskElevenRandomNumbersArray[i] == taskElevenRandomNumbersArray[j])
            //                {
            //                    taskElevenQuantityOfDifferentValues++;
            //                }
            //            }
            //        }
            //    }
            //    Console.WriteLine($"\nQuantity of different values in Array: {taskElevenQuantityOfDifferentValues}\n");

            //}

            /* ========== End of Part 2 Main ========== */
            Console.ReadLine();
        }

        /* ========== Start of Part 1 Methods ===== */

        //static int GetRandomIntNumber(int randomFrom, int randomTo)
        //{
        //    Random randomizer = new Random();
        //    int randomNumber;
        //    randomNumber = randomizer.Next(randomFrom, randomTo);
        //    return randomNumber;
        //}

        static int GetBiggerSecondNumber(int firstLesserNumber)
        {
            Random randomizer = new Random();
            int secondBiggerNumber;
            do
            {
                secondBiggerNumber = randomizer.Next(-49, 50);
            } while (firstLesserNumber >= secondBiggerNumber);
            return secondBiggerNumber;
        }

        static int GetCountOfNumbersInRangeIncluding(int firstNumber, int secondNumber)
        {
            int countOfNumbers = Math.Abs(secondNumber - firstNumber + 1);
            return countOfNumbers;
        }

        static int GetCountOfNumbersInRangeExcluding(int firstNumber, int secondNumber)
        {
            int countOfNumbers = Math.Abs(secondNumber - firstNumber - 1);
            return countOfNumbers;
        }

        static int[] GetAllNumbersInRangeIncreasing(int countOfNumbers, int firstElementValue)
        {
            int[] allNumbersInRange = new int[countOfNumbers];
            for (int i = 0; i < allNumbersInRange.Length; i++)
            {
                allNumbersInRange[i] = firstElementValue;
                firstElementValue++;
            }
            return allNumbersInRange;
        }

        static int[] GetAllNumbersInRangeDecreasing(int countOfNumbers, int lastElementValue)
        {
            int[] allNumbersInRange = new int[countOfNumbers];
            for (int i = 0; i < allNumbersInRange.Length; i++)
            {
                allNumbersInRange[i] = lastElementValue-1;
                lastElementValue--;
            }
            return allNumbersInRange;
        }

        static int[] GetNFirstPositiveOddNumbers(int numberOfNumbers)
        {
            int[] nFirstPositiveOddNumbers = new int[numberOfNumbers];
            int firstOddPositiveNumber = 1;

            for (int i = 0; i < nFirstPositiveOddNumbers.Length; i++)
            {
                nFirstPositiveOddNumbers[i] = firstOddPositiveNumber;
                firstOddPositiveNumber += 2;
            }

            return nFirstPositiveOddNumbers;
        }

        static int[] GetRandomNumbersArray(int arrayLenght, int randomFrom, int randomTo)
        {
            int[] randomNumbersArray = new int[arrayLenght];
            Random randomizer = new Random();
            
            for (int i = 0; i < randomNumbersArray.Length; i++)
            {
                randomNumbersArray[i] = randomizer.Next(randomFrom, randomTo);
            }

            return randomNumbersArray;
        }

        /* ========== End of Part 1 Methods ======= */
        /* ========== Start of Part 2 Methods ===== */
    }
}
