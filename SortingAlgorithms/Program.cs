using System;
using SortingAlgorithms;

namespace SortingAlgorithms {

    class Program {

        static void Main(string[] args) {

            Console.WriteLine("Source array:");
            PrintArray(GetArray(), ConsoleColor.Red);
            Console.WriteLine();

            Console.WriteLine("Selection sort:");
            PrintArray(Sorting.SelectionSort(GetArray()), ConsoleColor.Green);
            Console.WriteLine();

            Console.WriteLine("Insertion sort:");
            PrintArray(Sorting.InsertionSort(GetArray()), ConsoleColor.Green);
            Console.WriteLine();

            Console.WriteLine("Bubble sort:");
            PrintArray(Sorting.BubbleSort(GetArray()), ConsoleColor.Green);
            Console.WriteLine();

            Console.WriteLine("Cocktail sort:");
            PrintArray(Sorting.CocktailSort(GetArray()), ConsoleColor.Green);
            Console.WriteLine();

            Console.WriteLine("Merge sort:");
            PrintArray(Sorting.MergeSort(GetArray()), ConsoleColor.Green);
            Console.WriteLine();

            Console.ReadKey();
        }

        private static int[] GetArray()
        {
            return new int[] { 12, 43, 1, 0, 1, 3, 0, 7, 8, 4, 7, 9, 24, 56, 7 };
        }

        private static void PrintArray(int[] array, ConsoleColor consoleColor = ConsoleColor.White)
        {
            Console.ForegroundColor = consoleColor;

            foreach (int i in array) { Console.Write("{0} ", i); }
            
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}