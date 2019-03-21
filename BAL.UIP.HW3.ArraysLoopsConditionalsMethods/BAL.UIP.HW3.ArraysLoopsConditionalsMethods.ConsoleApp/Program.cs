using System;
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
                
                int taskOneNumberOfNumbers = GetNumberOfNumbersInRangeIncluding(taskOneVariableOne, taskOneVariableTwo);

                int[] taskOneAllNumbersInRange = new int[taskOneNumberOfNumbers];

                taskOneAllNumbersInRange = GetAllNumbersInRangeIncreasing(taskOneNumberOfNumbers, taskOneVariableOne);

                Console.WriteLine($"Number of numbers between {taskOneVariableOne} and {taskOneVariableTwo} (including): {taskOneNumberOfNumbers}");
                Console.Write($"Numbers between {taskOneVariableOne} and {taskOneVariableTwo} (increasing): ");
                foreach (int number in taskOneAllNumbersInRange)
                {
                    if (number != taskOneVariableTwo)
                    {
                        Console.Write($"{number}, ");
                    }
                    else
                    {
                        Console.Write($"{number}");
                    }
                }
                Console.WriteLine("\n");
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

                int taskTwoNumberOfNumbers = GetNumberOfNumbersInRangeExcluding(taskTwoVariableOne, taskTwoVariableTwo);

                int[] taskTwoAllNumbersInRange = new int[taskTwoNumberOfNumbers];

                taskTwoAllNumbersInRange = GetAllNumbersInRangeDecreasing(taskTwoNumberOfNumbers, taskTwoVariableTwo);

                Console.WriteLine($"Number of numbers between {taskTwoVariableOne} and {taskTwoVariableTwo} (excluding): {taskTwoNumberOfNumbers}");
                if (taskTwoNumberOfNumbers != 0)
                {
                    Console.Write($"Numbers between {taskTwoVariableOne} and {taskTwoVariableTwo} (decreasing): ");
                    foreach (int number in taskTwoAllNumbersInRange)
                    {
                        if (number != taskTwoVariableOne+1)
                        {
                            Console.Write($"{number}, ");
                        }
                        else
                        {
                            Console.Write($"{number}");
                        }
                    }
                }
                Console.WriteLine("\n");
            }


            // Task 3. Начальный вклад в банке равен $1000.
            // Через каждый месяц размер вклада увеличивается на P процентов от имеющейся суммы (P — вещественное число, 0 < P < 25).
            // По данному P определить, через сколько месяцев размер вклада превысит $1100,
            // и вывести найденное количество месяцев K (целое число)
            // и итоговый размер вклада S (вещественное число).
            if (true)
            {
                int startMoneyAmount = 1000;
                double increasingValue = randomizer.Next(1, 25);
                double monthlyPercents = increasingValue / 100;
                int totalMonthes = 0;
                double totalMoneyAmount = startMoneyAmount;


                while (totalMoneyAmount <= 1100)
                {
                    totalMoneyAmount = totalMoneyAmount + totalMoneyAmount * monthlyPercents;
                    totalMonthes++;
                }

                Console.WriteLine($"Total monthes K: {totalMonthes}");
                Console.Write($"Total money amount S: {totalMoneyAmount}");
            }

            Console.ReadLine();
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

        static int GetNumberOfNumbersInRangeIncluding(int firstNumber, int secondNumber)
        {
            int numberOfNumbers = Math.Abs(secondNumber - firstNumber + 1);
            return numberOfNumbers;
        }

        static int GetNumberOfNumbersInRangeExcluding(int firstNumber, int secondNumber)
        {
            int numberOfNumbers = Math.Abs(secondNumber - firstNumber - 1);
            return numberOfNumbers;
        }

        static int[] GetAllNumbersInRangeIncreasing(int numberOfNumbers, int firstElementValue)
        {
            int[] allNumbersInRange = new int[numberOfNumbers];
            for (int i = 0; i < allNumbersInRange.Length; i++)
            {
                allNumbersInRange[i] = firstElementValue;
                firstElementValue++;
            }
            return allNumbersInRange;
        }

        static int[] GetAllNumbersInRangeDecreasing(int numberOfNumbers, int lastElementValue)
        {
            int[] allNumbersInRange = new int[numberOfNumbers];
            for (int i = 0; i < allNumbersInRange.Length; i++)
            {
                allNumbersInRange[i] = lastElementValue-1;
                lastElementValue--;
            }
            return allNumbersInRange;
        }
    }
}
