//O(log n)
using System;

public class QuickSort
{
    public static void QuickSorting(int[] arr, int start, int end)
    {
        if (start >= end)
        {
            return;
        }

        int pivot = arr[end];
        int left = start;

        for (int i = start; i < end; i++)
        {
            if (arr[i] < pivot)
            {
                int tmp = arr[left];
                arr[left] = arr[i];
                arr[i] = tmp;
                left++;
            }
        }

        arr[end] = arr[left];
        arr[left] = pivot;

        QuickSorting(arr, start, left - 1);
        QuickSorting(arr, left + 1, end);
    }

    public static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        var numbers = new int[] { 5, 4, 9, 8, 1, 2, 0, 7 };
        var end = numbers.Length - 1;

        QuickSorting(numbers, 0, end);
        PrintArray(numbers);
    }
}
