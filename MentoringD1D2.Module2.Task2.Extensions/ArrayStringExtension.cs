using System;
using System.Linq;
using MentoringD1D2.Module2.Task2.Extensions.Enums;

namespace MentoringD1D2.Module2.Task2.Extensions
{
    /// <summary>
    /// An extension for array of string that provides sorting.
    /// </summary>
    public static class ArrayStringExtension
    {
        /// <summary>
        /// Returns sorted array considering sortorder and sortcomparsion.
        /// </summary>
        /// <param name="array">The array that should be sorted.</param>
        /// <param name="stringComparison">The instance of StringComparsion.</param>
        /// <param name="sortOrder">The sort order (Ascending or Descending).</param>
        /// <exception cref="ArgumentNullException">Trown when array is null</exception>
        /// <returns>The sorted array of string</returns>
        public static string[] CustomSort(this string[] array,
            StringComparison stringComparison = StringComparison.OrdinalIgnoreCase, SortOrder sortOrder = SortOrder.Ascending)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));
            if (array.Length == 0)
                return array;
            int left = 0;
            int right = array.Count() - 1;
            InternalQuickSort(array, left, right, stringComparison, sortOrder);
            return array;
        }

        /// <summary>
        /// Internal recursive sort algorithm for quick sort using divide and conquer. Sorting is done based on pivot
        /// </summary>
        /// <param name="array">The array that should be sorted.</param>
        /// <param name="left">The left partition of array.</param>
        /// <param name="right">The sort order (Ascending or Descending).</param>
        /// <param name="stringComparison">The instance of StringComparsion.</param>
        /// <param name="sortOrder">The sort order (Ascending or Descending).</param>
        private static  void InternalQuickSort(string[] array, int left, int right, StringComparison stringComparison, SortOrder sortOrder)
        {
            int pivotNewIndex = FindPartition(array, left, right, stringComparison, sortOrder);
            if (left < pivotNewIndex - 1)
                InternalQuickSort(array, left, pivotNewIndex - 1, stringComparison, sortOrder);
            if (pivotNewIndex < right)
                InternalQuickSort(array, pivotNewIndex, right, stringComparison, sortOrder);
        }


        /// <summary>
        /// Returns a new pivot everytime it is called recursively and swaps the array elements based on pivot value comparison.
        /// </summary>
        /// <param name="array">The array that should be sorted.</param>
        /// <param name="left">The left partition of <c>array</c>.</param>
        /// <param name="right">The right partition of <c>array</c>.</param>
        /// <param name="stringComparison">The instance of StringComparsion.</param>
        /// <param name="sortOrder">The sort order (Ascending or Descending).</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the pivot is out of range.</exception>
        /// <returns>The new pivot.</returns>
        private static int FindPartition(string[] array, int left, int right, StringComparison stringComparison, SortOrder sortOrder)
        {
            if (left < 0 || right < 0 || left > array.Length - 1 || right > array.Length - 1)
                throw new ArgumentOutOfRangeException($"The pivot {left} or {right} is out of range");
            int i = left, j = right;
            string pivot = array[(left + right) / 2];
            while (i <= j)
            {
                while ((sortOrder == SortOrder.Ascending) ? String.Compare(array[i], pivot, stringComparison) < 0 : String.Compare(array[i], pivot, stringComparison) > 0)
                    i++;
                while ((sortOrder == SortOrder.Ascending) ? String.Compare(array[j], pivot, stringComparison) > 0 : String.Compare(array[j], pivot, stringComparison) < 0)
                    j--;
                if (i <= j)
                {
                    Swap(ref array[i], ref array[j]);
                    i++; j--;
                }
            }
            return i;
        }

        /// <summary>
        /// Swaps the elements of the string array.
        /// </summary>
        /// <param name="left">The first element.</param>
        /// <param name="right">The second element.</param>
        private static void Swap(ref string left, ref string right)
        {
            string tmp = left;
            left = right;
            right = tmp;
        }
    }
}
