using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms {

    class Sorting {

        public static int[] CocktailSort(int[] array)
        {
            int arrayLength = array.Length;

            if (arrayLength > 1) 
            {
                int left = 0;
                int right = arrayLength - 1;

                while (left < right) 
                {
                    for (int j = left; j < right; j++)
                    {
                        if (array[j] > array[j + 1]) 
                        {
                            Swap(array, j, j + 1);
                        }
                    }

                    right--;

                    for (int j = right; j > left; j--) 
                    {
                        if (array[j] < array[j - 1]) 
                        {
                            Swap(array, j, j - 1);
                        }
                    }

                    left++;
                }
            }

            return array;
        }

        public static int[] BubbleSort(int[] array)
        {
            int arrayLength = array.Length;

            if (arrayLength <= 1) { return array; }

            for (int i = 0; i <= arrayLength - 1; i++) 
            {
                for (int j = 0; j <= arrayLength - i - 2; j++) 
                {
                    if (array[j] > array[j + 1]) 
                    {
                        Swap(array, j, j + 1);
                    }    
                }
            }

            return array;
        }

        public static int[] InsertionSort(int[] array)
        {
            int arrayLength = array.Length;

            if (arrayLength <= 1) { return array; }

            int tmp = 0;

            for (int i = 1; i <= arrayLength - 1; i++) 
            {
                tmp = array[i];

                for (int j = i - 1; j >= 0; j--) 
                {
                    if (tmp < array[j]) 
                    {
                        array[j + 1] = array[j];
                        array[j] = tmp;
                    }
                }
            }

            return array;
        }

        public static int[] SelectionSort(int[] array)
        {
            int arrayLength = array.Length;

            if (arrayLength <= 1) { return array; }

            int min = 0;

            for (int i = 0; i <= arrayLength - 1; i++) {

                min = array[i];

                for (int j = i; j <= arrayLength - 1; j++) 
                {
                    if (array[j] < min) 
                    {
                        min = array[j];
                        array[j] = array[i];
                        array[i] = min;
                    }
                }
            }

            return array;
        }


        private static void Swap(int[] array, int i, int j)
        {
            int tmp;
            tmp = array[i];
            array[i] = array[j];
            array[j] = tmp;
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