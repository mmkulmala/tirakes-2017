using System;

namespace mymsort
{
    class Program
    {
        static public void MainMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, eol, num, pos;
 
            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);
 
            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }
 
            while (left <= eol)
                temp[pos++] = numbers[left++];
 
            while (mid <= right)
                temp[pos++] = numbers[mid++];
 
            for (i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }
 
        static public void SortMerge(int[] numbers, int left, int right)
        {
            int mid;
 
            if (right > left)
            {
                mid = (right + left) / 2;
                SortMerge(numbers, left, mid);
                SortMerge(numbers, (mid + 1), right);
 
                MainMerge(numbers, left, (mid + 1), right);
            }
        }
 
        static public void MainMergeGen<T>(T[] values, int left, int mid, int right) where T : IComparable<T>
        {
            T[] temp = new T[25];
            int i, eol, num, pos;

            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (values[left].CompareTo(values[mid]) < 0)
                    temp[pos++] = values[left++];
                else
                    temp[pos++] = values[mid++];
            }

            while (left <= eol)
                temp[pos++] = values[left++];

            while (mid <= right)
                temp[pos++] = values[mid++];

            for (i = 0; i < num; i++)
            {
                values[right] = temp[right];
                right--;
            }
        }

        static public void SortMergeGen<T>(T[] values, int left, int right) where T : IComparable<T>
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                SortMergeGen(values, left, mid);
                SortMergeGen(values, (mid + 1), right);

                MainMergeGen(values, left, (mid + 1), right);
            }
        }

       static void Quicksort2(int[] arr, int begin, int end)
        {
            int pivot = arr[(begin + (end - begin) / 2)];
            int left = begin;
            int right = end;
            while (left <= right)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left <= right)
                {
                    swap(arr, left, right);
                    left++;
                    right--;
                }
            }
            if (begin < right)
            {
                Quicksort2(arr, begin, left - 1);
            }
            if (end > left)
            {
                Quicksort2(arr, right + 1, end);
            }
        }

        static void swap(int[] items, int x, int y)
        {
            int temp = items[x];
            items[x] = items[y];
            items[y] = temp;
        }

        static void SystemQSort(int[] arr) {
            Array.Sort(arr);
            Array.Reverse(arr);
        }
 
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("** Tehtävä 1 alkaa **");
            int[] numbers = new int[9] {7, 3, 12, 6, 2, 15, 4, 18, 12};
            Console.WriteLine("  Taulu alussa:");
            Console.Write("  [");
            for (int i = 0; i < numbers.Length; i++) {
                if (i < numbers.Length - 1) {
                    Console.Write(numbers[i] + ",");
                } else {
                   Console.Write(numbers[i]); 
                }
            }
            Console.Write("]");
            Console.WriteLine("");
            Console.WriteLine("  MergeSort nousevana:");
            SortMerge(numbers, 0, numbers.Length - 1);
            Console.Write("  [");
            for (int i = 0; i < numbers.Length; i++) {
                if (i < numbers.Length - 1) {
                    Console.Write(numbers[i] + ",");
                } else {
                   Console.Write(numbers[i]); 
                }
            }
            Console.Write("]");
            Console.WriteLine("");
            Console.WriteLine("** Tehtävä 1 loppuu **");
            Console.WriteLine("");
            Console.WriteLine("** Tehtävä 2 alkaa **");
            string[] cities = new string[6]{"Nevada", "Nebraska", "North Carolina", "Arizona", "Florida", "New Hampshire"};
            Console.WriteLine("  Taulu alussa:");
            Console.Write("  [");
            for (int i = 0; i < cities.Length; i++) {
                if (i < cities.Length - 1) {
                    Console.Write(cities[i] + ",");
                } else {
                   Console.Write(cities[i]); 
                }
            }
            Console.Write("]");
            Console.WriteLine("");
            Console.WriteLine("  Kaupungit MergeSortin avulla aakkosjärjestyksessä:");
            SortMergeGen(cities, 0, cities.Length - 1);
            Console.Write("  [");
            for (int i = 0; i < cities.Length; i++) {
                if (i < cities.Length - 1) {
                    Console.Write(cities[i] + ",");
                } else {
                   Console.Write(cities[i]); 
                }
            }
            Console.Write("]");
            Console.WriteLine("");
            Console.WriteLine("** Tehtävä 2 loppuu **");
            Console.WriteLine("");
            Console.WriteLine("** Tehtävä 3 alkaa **");
            int[] A = new int[16] { 38, 32, 31, 30, 48, 48, 28, 46, 16, 5, 43, 12, 14, 15, 25, 27 };
            Console.WriteLine("  Taulu alussa:");
            Console.Write("  [");
            for (int i = 0; i < A.Length; i++) {
                if (i < A.Length - 1) {
                    Console.Write(A[i] + ",");
                } else {
                   Console.Write(A[i]); 
                }
            }
            Console.Write("]");
            Console.WriteLine("");
            Console.WriteLine("  Quicksortattuna:");
            Quicksort2(A, 0, A.Length - 1);
            Console.Write("  [");
            for (int i = A.Length -1; i >= 0; i--) {
                if (i == 0) {
                    Console.Write(A[i]);
                } else {
                   Console.Write(A[i] + ","); 
                }
            }
            Console.Write("]");
            Console.WriteLine("");
            Console.WriteLine("** Tehtävä 3 loppuu **");
            Console.WriteLine("");
            Console.WriteLine("** Tehtävä 4 alkaa: System QuickSort **");
            int[] A2 = new int[16] { 38, 32, 31, 30, 48, 48, 28, 46, 16, 5, 43, 12, 14, 15, 25, 27 };
            Console.WriteLine("  Taulu alussa:");
            Console.Write("  [");
            for (int i = 0; i < A2.Length; i++) {
                if (i < A2.Length - 1) {
                    Console.Write(A2[i] + ",");
                } else {
                   Console.Write(A2[i]); 
                }
            }
            Console.Write("]");
            Console.WriteLine("");
            Console.WriteLine("  Quicksortattuna:");
            SystemQSort(A2);
            Console.Write("  [");
            for (int i = 0; i < A2.Length; i++) {
                if (i < A.Length - 1) {
                    Console.Write(A2[i] + ",");
                } else {
                   Console.Write(A2[i]); 
                }
            }
            Console.Write("]");
            Console.WriteLine("");
            Console.WriteLine("** Tehtävä 4 loppuu **");
            Console.WriteLine("");
        }
    }
}