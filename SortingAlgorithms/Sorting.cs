using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms {

    class Sorting {

        public static int[] MergeSort(int[] array)
        {
            int arrayLength = array.Length;

            if (arrayLength > 1) 
            {
                int leftLength = ((arrayLength % 2) != 0) ? (arrayLength / 2 + 1) : (arrayLength / 2);
                int rightLength = ((arrayLength % 2) != 0) ? (leftLength - 1) : (leftLength);
                int j = 0;

                int[] left = new int[leftLength];
                int[] right = new int[rightLength];
                int[] result = new int[arrayLength];

                for (int i = 0; i < leftLength; i++)  // Левую половину массива помещаем в left[]
                { 
                    left[i] = array[i];
                }

                for (int i = leftLength; i <= arrayLength - 1; i++) // Правую половину массива помещаем в right[]
                { 
                    right[j] = array[i];
                    j++;
                }

                left = MergeSort(left);
                right = MergeSort(right);
                result = Merge(left, right);

                return result.ToArray();
            }
            
            return array;       
        }

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


        private static int[] Merge(int[] left_in, int[] right_in)
        {
            List<int> left = left_in.ToList();
            List<int> right = right_in.ToList();
            List<int> result = new List<int>();

            while (left.Count() > 0 && right.Count() > 0) 
            {
                if (left.First() <= right.First()) 
                {
                    result.Add(left.First());
                    left.RemoveAt(0);
                }
                else 
                {
                    result.Add(right.First());
                    right.RemoveAt(0);
                }
            }

            if (left.Count() > 0) { result.AddRange(left); }
            if (right.Count() > 0) { result.AddRange(right); }

            return result.ToArray();
        }

        private static void Swap(int[] array, int i, int j)
        {
            int tmp;
            tmp = array[i];
            array[i] = array[j];
            array[j] = tmp;
        }
    }
}