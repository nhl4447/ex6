using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp1.lesson6
{
    internal class ex6part2
    {
       
//Requests 10 integers from the user and orders them by implementing the bubble sort algorithm.
       static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap arr[j] and arr[j + 1]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        public static void Main2(string[] args)
        {
            int[] numbers = new int[10];
            Console.WriteLine("Enter 10 integers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            BubbleSort(numbers);
            Console.WriteLine("Sorted numbers:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
        }


    }
}
