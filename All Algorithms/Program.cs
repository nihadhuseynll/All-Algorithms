using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Algorithms
{
	internal class Program
	{
		public static int Search(int[] arr,int N,int x)
		{
			for(int i = 0; i < N; i++)
			{
				if (arr[i] == x)
				{
					return i;
				}
			}
			return -1;
		}

		static void Main(string[] args)
		{
			int[] arr = { 1, 2, 3 , 4, 6 };
			Console.Write("Please Enter the target value  - ");
			int x = int.Parse(Console.ReadLine());

			// Function Call
			int result = Search(arr, arr.Length, x);
			if (result == -1)
				Console.WriteLine("Element is not present in array");
			else
				Console.WriteLine("Element is present at index - " + result);
			Console.ReadLine();	
		}
	}
}
