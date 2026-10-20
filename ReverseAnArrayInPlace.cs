// Reverese an array in place
using System;

class Pratice
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Original array: " + string.Join(", ", arr));
        ReverseArrayInPlace(arr);
        Console.WriteLine("Reversed array: " + string.Join(", ", arr));

    }
    public static ReverseArrayInPlace(int[] arr)
    {
        int start =0;
        int end = arr.Length-1;

        while(start< end)
        {
            int temp = arr[start];
            arr[start]= arr[end];
            arr[end]= temp;

            start++;
            end--;
        }

    }
}