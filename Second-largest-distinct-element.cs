// Find the second largest distinct element
using System;

class Pratice
{
	static void Main()
	{
		int[] arr = {12,34,4,12,4,9,7};
		Console.WriteLine("Second largest distict elemet is :"+ second_largest(arr));
		

	}

	public static int? second_largest(int[] arr)
	{
		int largest = arr[0];
		int? secondLargest = null;
		
		foreach(int num in arr)
		{
			if(num > largest)
			{
				secondLargest = largest;
				largest = num;
			}
			else
			{
				if(num < largest && (secondLargest == null || num >secondLargest))
				{
					secondLargest= num;					
				}
			
			}
		}
		if(secondLargest == null)
		{
			Console.WriteLine("No value for second largest");
		}
		return secondLargest;
	}
}