using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms {

    class Sorting {

        public static int[] InsertionSort(int[] sourceArray)
        {
            int arrayLength = sourceArray.Length;

            if (arrayLength == 1) { return sourceArray; }

            for (int i = 1; i <= arrayLength - 1; i++)
            {
                for (int j = i - 1; j == 0; j--) 
                {
                    while (sourceArray[i] < sourceArray[j]) {
                        sourceArray[j] = sourceArray[j - 1];
                    }
                }
            }

            return sourceArray;
        }

        public static int[] SelectionSort(int[] sourceArray)
        {
            int arrayLength = sourceArray.Length;
            int[] sortedArray = new int[arrayLength];

            for (int i = 0; i <= arrayLength - 1; i++) {
                sortedArray[i] = sourceArray[i];
            }

            if (arrayLength == 1) { return sortedArray; }

            int min = 0;

            for (int i = 0; i <= arrayLength - 1; i++) {

                min = sortedArray[i];

                for (int j = i; j <= arrayLength - 1; j++) 
                {
                    if (sortedArray[j] < min) 
                    {
                        min = sortedArray[j];
                        sortedArray[j] = sortedArray[i];
                        sortedArray[i] = min;
                    }
                }
            }

            return sortedArray;
        }

        public static int[] GenerateArrayRandomNumbers(int numbersCount = 30)
        {
            int[] array = new int[numbersCount];
            Random random = new Random();

            for (int i = 0; i < numbersCount; i++) {
                array[i] = random.Next(0, numbersCount); ;
            }

            return array;
        }

        public static void PrintArray(int[] array)
        {
            foreach (int i in array) {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}