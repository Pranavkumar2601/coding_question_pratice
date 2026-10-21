// Move all the zeroes to the end of the array while maintaining the order of non-zero elements.
using System;

class Practice
{
    static void Main()
    {
        int[] arr = { 0,5,2,5,0,4,0,1};

		MoveZerotoEnd(arr);

		Console.WriteLine(string.Join(", ", arr));
       
    }

    public static void  MoveZerotoEnd(int[] arr)
    {
		
		int pointer =0;
		int nextPosition=0; //read the non-zero element and move after assignment ;

		for (int i=0; i< arr.Length; i++)
		{
			if(arr[i] != 0)
			{
				arr[nextPosition]=arr[i];
				nextPosition++;
			}

		}
		while(nextPosition < arr.Length)
		{
			arr[nextPosition]=0;
			nextPosition++;
		}
		
    }
}