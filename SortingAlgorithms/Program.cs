using System;

namespace SortingAlgorithms {

    class Program {

        static void Main(string[] args) {

            int[] array = Sorting.GenerateArrayRandomNumbers(20);

            Console.WriteLine("Source array:");
            Sorting.PrintArray(array);
            Console.WriteLine();

            Console.WriteLine("Selection sort:");
            Sorting.PrintArray(Sorting.SelectionSort(array));
            Console.WriteLine();

            Console.WriteLine("Insertion sort:");
            Sorting.PrintArray(Sorting.InsertionSort(array));
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}