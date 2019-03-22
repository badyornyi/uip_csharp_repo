﻿using System;
using System.Collections;
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
            if(false)
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
            if (false)
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
            if (false)
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
            if (false)
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
            if (false)
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
            if (false)
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
            if (false)
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
            if (true)
            {
                Console.WriteLine("Task 8.");
                int taskEightVariableN = randomizer.Next(10, 10);
                int taskEightQuantityOfSameValues = 0;

                int[] taskEightRandomNumbersArray = GetRandomNumbersArray(taskEightVariableN, 0, 10);
                Console.WriteLine($"Given Array:");
                for (int i = 0; i < taskEightRandomNumbersArray.Length; i++)
                {
                    Console.Write($"{taskEightRandomNumbersArray[i]}, ");
                }
                
                for (int i = 0; i < taskEightRandomNumbersArray.Length; i++)
                {
                    for (int j = i + 1; j < taskEightRandomNumbersArray.Length; j++)
                    {
                        if (taskEightRandomNumbersArray[j] == taskEightRandomNumbersArray[i])
                        {
                            taskEightQuantityOfSameValues++;
                            break;
                        }
                    }
                }
                int taskEightQuantityOfUniqueValues = taskEightRandomNumbersArray.Length - taskEightQuantityOfSameValues;

                Console.WriteLine($"\nQuantity of different values in Array: {taskEightQuantityOfUniqueValues}\n");
            }


            // Task 9. Дано целое число N (> 0).
            // Найти произведение N! = 1·2·…·N (N–факториал).
            // Чтобы избежать целочисленного переполнения, вычислять это произведение с помощью вещественной переменной
            // и вывести его как вещественное число. Использовать рекурсию.
            if (true)
            {
                Console.WriteLine("Task 9.");
                int taskNineVariableN = randomizer.Next(1, 50);

                double nFactorial = GetFactorialForNumber(taskNineVariableN);

                Console.WriteLine($"{taskNineVariableN}! = {nFactorial}");
                Console.WriteLine("\n");
            }


            // Task 10. Написать метод, который считает и выводит на консоль последовательность Фибоначчи
            // (число элементов в последовательности принимается, как входящий параметр), используя рекурсию.
            if (true)
            {
                Console.WriteLine("Task 10.");
                int taskTenVariableN = randomizer.Next(3, 23);
                int firstNumber = 0;
                int secondNumber = 1;
                int sequencePosition = 1;

                Console.WriteLine($"Fibonacci sequence for {taskTenVariableN} numbers:");
                WriteFibonacciSequenceForN(firstNumber, secondNumber, sequencePosition, taskTenVariableN);

                Console.WriteLine("\n");
            }


            // Task 11. Создать метод вычисляющий количество дней в месяце определённого года
            // (с учётом високосности года)
            if (true)
            {
                Console.WriteLine("Task 11.");
                int taskElevenYear = randomizer.Next(1, 2030);
                int taskElevenMonth = randomizer.Next(1, 12);

                int daysInMonthForYear = GetDaysCountInMonthForYear(taskElevenMonth, taskElevenYear);

                Console.WriteLine($"There are {daysInMonthForYear} days in №{taskElevenMonth} month for {taskElevenYear} year");
                Console.WriteLine("\n");
            }


            // Task 12. Дан массив размера N.
            // Обнулить элементы массива, расположенные между его минимальным и максимальным элементами
            // (не включая минимальный и максимальный элементы).
            if (true)
            {
                Console.WriteLine("Task 12.");
                int taskTwelveVariableN = randomizer.Next(1, 50);

                int[] taskTwelveRandomNumbersArray = GetRandomNumbersArray(taskTwelveVariableN, 0, 50);

                Console.WriteLine($"Given Array:");
                WriteSingleArrayToConsole(taskTwelveRandomNumbersArray);
                
                int minValueIndex = GetArrayElementFirstIndexByValue(taskTwelveRandomNumbersArray.Min(), taskTwelveRandomNumbersArray);
                int maxValueIndex = GetArrayElementFirstIndexByValue(taskTwelveRandomNumbersArray.Max(), taskTwelveRandomNumbersArray);

                int startElementIndex = minValueIndex < maxValueIndex ? minValueIndex : maxValueIndex;
                int endElementIndex = minValueIndex < maxValueIndex ? maxValueIndex : minValueIndex;

                for (int i = startElementIndex + 1; i < endElementIndex; i++)
                {
                    taskTwelveRandomNumbersArray[i] = 0;
                }

                Console.WriteLine($"Result Array:");
                WriteSingleArrayToConsole(taskTwelveRandomNumbersArray);
                Console.WriteLine("\n");
            }


            // Task 13. Создайте массив N (случайноe число от 1 до 10)
            // с массивами длинной М (случайноe число от 20 до 50).
            // Заполните его случайными целыми числами от 0 до 9.
            // Выведите массив на экран.
            // Отсортируйте каждую строку массива, по возрастанию.
            // Выведите преобразованный массив на экран.
            if (true)
            {
                Console.WriteLine("Task 13.");
                int task13VarN = randomizer.Next(1, 10);
                int task13VarM = randomizer.Next(20, 50);
                Console.WriteLine($"Array size: [{task13VarN}][{task13VarM}]");

                int[][] task13RandomNumbersJaggedArray = GetRandomNumbersJaggedArray(task13VarN, task13VarM);

                Console.WriteLine($"Given Array:");
                WriteJaggedArrayToConsole(task13RandomNumbersJaggedArray);

                for (int i = 0; i < task13RandomNumbersJaggedArray.Length; i++)
                {
                    Array.Sort(task13RandomNumbersJaggedArray[i]);
                }

                Console.WriteLine($"Result Array:");
                WriteJaggedArrayToConsole(task13RandomNumbersJaggedArray);
                Console.WriteLine("\n");
            }

            /* ========== End of Part 2 Main ========== */
            /* ========== Start of Part 3 Main ======== */

            // Task 14.
            if (false)
            {
                Console.WriteLine("Task 14.");

                Console.WriteLine("\n");
            }


            // Task 15.
            if (false)
            {
                Console.WriteLine("Task 15.");

                Console.WriteLine("\n");
            }


            // Task 16.
            if (false)
            {
                Console.WriteLine("Task 16.");

                Console.WriteLine("\n");
            }


            // Task 17.
            if (false)
            {
                Console.WriteLine("Task 17.");

                Console.WriteLine("\n");
            }


            // Task 18.
            if (false)
            {
                Console.WriteLine("Task 18.");

                Console.WriteLine("\n");
            }


            // Task 19.
            if (false)
            {
                Console.WriteLine("Task 19.");

                Console.WriteLine("\n");
            }

            /* ========== End of Part 3 Main ========== */
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

        static void WriteSingleArrayToConsole(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine();
        }

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

        static double GetFactorialForNumber(int number)
        {
            double factorial;

            factorial = number == 1 ? 1 : factorial = number * GetFactorialForNumber(number - 1);

            return factorial;
        }

        static void WriteFibonacciSequenceForN(int firstNumber, int secondNumber, int sequencePosition, int sequenceLenght)
        {
            int temp = 0;

            if(sequencePosition <= sequenceLenght)
            {
                string result = (sequencePosition != sequenceLenght) ? $"{firstNumber}, " : $"{firstNumber}";
                Console.Write(result);
                temp = firstNumber;
                firstNumber = secondNumber;
                secondNumber = firstNumber + temp;
                sequencePosition++;
                WriteFibonacciSequenceForN(firstNumber, secondNumber, sequencePosition, sequenceLenght);
            }
        }

        static int GetDaysCountInMonthForYear(int month, int year)
        {
            bool isYearLeap = IsYearLeap(year);
            int daysCountInMonthForYear = 0;

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    {
                        daysCountInMonthForYear = 31;
                        break;
                    }
                case 4:
                case 6:
                case 9:
                case 11:
                    {
                        daysCountInMonthForYear = 30;
                        break;
                    }
                case 2:
                    {
                        daysCountInMonthForYear = isYearLeap ? 29 : 28;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Wrong Month number");
                        break;
                    }
            }

            return daysCountInMonthForYear;
        }

        static bool IsYearLeap(int year)
        {
            bool isYearLeap = false;

            bool isYearCentury = year % 100 == 0;

            if (isYearCentury && (year % 400 == 0))
            {
                isYearLeap = true;
            }
            else if (!isYearCentury && (year % 4 == 0))
            {
                isYearLeap = true;
            }
            else
            {
                isYearLeap = false;
            }
            //Console.WriteLine($"Year {year} leap? {isYearLeap}");

            return isYearLeap;
        }

        static int GetArrayElementFirstIndexByValue(int value, int[] array)
        {
            int valueIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    valueIndex = i;
                    break;
                }
            }
            return valueIndex;
        }

        static int[][] GetRandomNumbersJaggedArray(int firstDimensionLenght, int secondDimensionLenght)
        {
            int[][] jaggedArray = new int[firstDimensionLenght][];
            Random randomizer = new Random();

            for (int i = 0; i < firstDimensionLenght; i++)
            {
                jaggedArray[i] = new int[secondDimensionLenght];
                for (int j = 0; j < secondDimensionLenght; j++)
                {
                    jaggedArray[i][j] = randomizer.Next(0, 9);
                }

            }
            return jaggedArray;
        }

        static void WriteJaggedArrayToConsole(int[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"{jaggedArray[i][j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        /* ========== End of Part 2 Methods ======= */
        /* ========== Start of Part 3 Methods ===== */


    }
}
