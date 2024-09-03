using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Algorithms
{
	internal class Program
	{
		// 1.Linear Search Alogrithm

		//public static int Search(int[] arr,int N,int x)
		//{
		//	for(int i = 0; i < N; i++)
		//	{
		//		if (arr[i] == x)
		//		{
		//			return i;
		//		}
		//	}
		//	return -1;
		//}

		//static void Main(string[] args)
		//{
		//	int[] arr = { 1, 2, 3 , 4, 6 };
		//	Console.Write("Please Enter the target value  - ");
		//	int x = int.Parse(Console.ReadLine());

		//	// Function Call
		//	int result = Search(arr, arr.Length, x);
		//	if (result == -1)
		//		Console.WriteLine("Element is not present in array");
		//	else
		//		Console.WriteLine("Element is present at index - " + result);

		//	Console.ReadLine();	
		//}

		// 2.Binary Search Algorithm

		static int BinarySearch(int[] arr,int x)
		{
			int low = 0,high = arr.Length-1;
			while (low <= high)
			{
				int mid = low + (high-low)/2;

				//Check if x is present at mid
				if (arr[mid] == x)
					return mid;

				//if x greater, ignore left hand
				if (arr[mid] < x)
					low = mid+1;

				// if x is smaller , ignore right hand
				else 
					high = mid-1;
			}

			//If we reach here , then element was not present 
			return -1;
		}

		static void Main(string[] args)
		{
			int[] arr = { 1, 2, 3, 4, 5, 6 };
			int x = 5;

			int result = BinarySearch(arr,x);
			if (result == -1)
				Console.WriteLine("Element is not present in array");
			else
				Console.WriteLine("Element is present at index  - " + result);

			Console.ReadLine();	
		}
	}
}
