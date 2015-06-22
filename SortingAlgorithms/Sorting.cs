using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms {

    class Sorting {

        private static int[] GenerateArrayNumbers()
        {
            const int NUMBERS_COUNT = 30;
            int[] array = new int[NUMBERS_COUNT];

            int randomNumber = 0;
            Random random = new Random();

            for (int i = 0; i < NUMBERS_COUNT; i++) {
                //do {
                //    randomNumber = random.Next(0, NUMBERS_COUNT);
                //}
                //while (array.Contains(randomNumber));

                randomNumber = random.Next(0, NUMBERS_COUNT);
                array[i] = randomNumber;
            }

            return array;
        }

        private static void PrintArray(int[] array)
        {
            foreach (int i in array) {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
