using System;
using System.Collections.Generic;

namespace Basic13
{
    class Program
    {
        public static void PrintNumbers()
        {
            int max = 255;
            for (int i = 1; i <= max; i++)
            {
                System.Console.WriteLine(i);
            }
        }

        public static void PrintOdds()
        {
            int max = 255;
            for (int i = 1; i <= max; i++)
            {
                if (i % 2 != 0)
                {
                    System.Console.WriteLine(i);
                }
            }
        }

        public static void PrintSum()
        {
            int max = 255;
            int sum = 0;
            for (int i = 0; i <= max; i++)
            {
                sum += i;
                System.Console.WriteLine($"New number: {i}   Sum: {sum}");
            }
        }

        public static void LoopArray(int[] numbers)
        {
            // Write a function that would iterate through each item of the given integer array and 
            // print each value to the console. 
            foreach (int num in numbers)
            {
                System.Console.WriteLine(num);
            }
        }

        public static int FindMax(int[] numbers)
        {
            // Write a function that takes an integer array and prints and returns the maximum value in the array. 
            // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
            // or even a mix of positive numbers, negative numbers and zero.
            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }

        public static void GetAverage(int[] numbers)
        {
            // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
            // For example, with an array [2, 10, 3], your program should write 5 to the console.
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            double avg = (double)sum / (double)numbers.Length;
            System.Console.WriteLine(avg);
        }

        public static int[] OddArray()
        {
            // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
            // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
            int[] odds = new int[255];
            for (int i = 0; i < 255; i++)
            {
                odds[i] = i + 1;
            }
            return odds;
        }

        public static int GreaterThanY(int[] numbers, int y)
        {
            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value. 
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).
            int result = 0;
            foreach (int num in numbers)
            {
                if (num > y)
                {
                    result++;
                }
            }
            return result;
        }

        public static void SquareArrayValues(int[] numbers)
        {
            // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
            // For example, [1,5,10,-10] should become [1,25,100,100]
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] * numbers[i];
            }
            foreach (int num in numbers)
            {
                System.Console.WriteLine(num);
            }
        }

        public static void EliminateNegatives(int[] numbers)
        {
            // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
            };
            foreach (int num in numbers)
            {
                System.Console.WriteLine(num);
            };
        }

        public static void MinMaxAverage(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.
            int max = numbers[0];
            int min = numbers[0];
            int sum = 0;
            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }
                sum += num;
            }
            double avg = (double)sum / (double)numbers.Length;
            System.Console.WriteLine($"Max: {max}   Min: {min}  Average: {avg}");
        }

        public static void ShiftValues(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, 7, -2], 
            // Write a function that shifts each number by one to the front and adds '0' to the end. 
            // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, copy
            // it should become [5, 10, 7, -2, 0]
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i != numbers.Length - 1)
                {
                    numbers[i] = numbers[i + 1];
                }
                else
                {
                    numbers[i] = 0;
                }
            }

            foreach (int num in numbers)
            {
                System.Console.WriteLine(num);
            }
        }

        public static object[] NumToString(int[] numbers)
        {
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].
            object[] result = new object[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    result[i] = "Dojo";
                }
                else
                {
                    result[i] = numbers[i];
                }
            }
            foreach (var item in result)
            {
                System.Console.WriteLine(item);
            }
            return result;
        }


        static void Main(string[] args)
        {
            // PrintNumbers();
            // PrintOdds();
            // PrintSum();

            int[] lArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // LoopArray(lArray);

            int[] negatives = { -3, -10, -30, 0 };
            int[] mixer = { -2, 4, -29, 0, 34, -39 };
            // System.Console.WriteLine(FindMax(lArray));
            // System.Console.WriteLine(FindMax(negatives));

            // GetAverage(lArray);
            // GetAverage(negatives);

            // System.Console.WriteLine(OddArray()[30]);

            // System.Console.WriteLine(GreaterThanY(lArray, 7));

            // SquareArrayValues(lArray);
            // SquareArrayValues(negatives);

            // EliminateNegatives(mixer);

            // MinMaxAverage(mixer);

            // ShiftValues(lArray);

            NumToString(mixer);
        }
    }
}
