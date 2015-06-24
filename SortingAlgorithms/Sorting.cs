using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms {

    class Sorting {

        public static int[] SelectionSort(int[] array)
        {
            int arrayLength = array.Length;
            int min = 0;

            for (int i = 0; i <= arrayLength - 1; i++) {

                min = array[i];

                for (int j = i; j <= arrayLength - 1; j++) 
                {
                    if ()

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
