using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BÀI_TẬP
{
    internal class Exercises_6
    {


        class Program
        {
            static void Main()
            {
                int[] arr = { 5, 8, 3, 5, 2, 8, 9, 1, 3, 7 };
                Console.WriteLine("Array: " + string.Join(", ", arr));

                Console.WriteLine("Average: " + CalculateAverage(arr));

                int valueToCheck = 5;
                Console.WriteLine("Contains " + valueToCheck + ": " + ContainsValue(arr, valueToCheck));

                Console.WriteLine("Index of " + valueToCheck + ": " + FindIndex(arr, valueToCheck));

                int[] removedArray = RemoveElement(arr, valueToCheck);
                Console.WriteLine("After removing " + valueToCheck + ": " + string.Join(", ", removedArray));

                FindMinMax(arr, out int min, out int max);
                Console.WriteLine("Min: " + min + ", Max: " + max);

                int[] reversed = ReverseArray(arr);
                Console.WriteLine("Reversed: " + string.Join(", ", reversed));

                Console.WriteLine("Duplicate values: " + string.Join(", ", FindDuplicates(arr)));

                int[] noDuplicates = RemoveDuplicates(arr);
                Console.WriteLine("Without duplicates: " + string.Join(", ", noDuplicates));
            }

            // 1. Calculate average
            static double CalculateAverage(int[] arr)
            {
                return arr.Average();
            }

            // 2. Check if array contains value
            static bool ContainsValue(int[] arr, int value)
            {
                return arr.Contains(value);
            }

            // 3. Find index
            static int FindIndex(int[] arr, int value)
            {
                return Array.IndexOf(arr, value);
            }

            // 4. Remove specific element (first occurrence)
            static int[] RemoveElement(int[] arr, int value)
            {
                List<int> list = new List<int>(arr);
                list.Remove(value);
                return list.ToArray();
            }

            // 5. Find min and max
            static void FindMinMax(int[] arr, out int min, out int max)
            {
                min = arr.Min();
                max = arr.Max();
            }

            // 6. Reverse array
            static int[] ReverseArray(int[] arr)
            {
                int[] newArr = (int[])arr.Clone();
                Array.Reverse(newArr);
                return newArr;
            }

            // 7. Find duplicates
            static List<int> FindDuplicates(int[] arr)
            {
                return arr.GroupBy(x => x)
                          .Where(g => g.Count() > 1)
                          .Select(g => g.Key)
                          .ToList();
            }

            // 8. Remove duplicates
            static int[] RemoveDuplicates(int[] arr)
            {
                return arr.Distinct().ToArray();
            }
        }
    }
}