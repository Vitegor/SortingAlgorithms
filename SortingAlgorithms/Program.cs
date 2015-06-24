using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms {

    class Program {

        static void Main(string[] args) {

            int[] array = Sorting.GenerateArrayRandomNumbers();

            Sorting.PrintArray(array);
            Sorting.PrintArray(array);

            Console.ReadKey();
        }
    }
}
