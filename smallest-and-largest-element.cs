// Find the smallest and largest element in an array.
using System;
class Program
{
    public static void Main()
    {
        int [] arr={ 8,12,5,17};
        int smallest = arr[0];
        int Largest = arr[0];

        foreach(int num in arr)
        {
            if(num < smallest)
            {
                smallest = num;
            
            }
            if(num > Largest)
            {
                Largest = num;
            }
        }
        Console.WriteLine($"Smallest element in the array is {smallest}");
        Console.WriteLine($"Largest element in the array is {Largest}");
    }
}