//O(n^2)
using System;

public class BubbleSort
{
    public static void BubbleSorting(int[] arr)
    {
        if (arr == null) return;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                }
            }
        }
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

        BubbleSorting(numbers);
        PrintArray(numbers);
    }
}