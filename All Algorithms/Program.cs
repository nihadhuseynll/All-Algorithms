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

		//static int BinarySearch(int[] arr,int x)
		//{
		//	int low = 0,high = arr.Length-1;
		//	while (low <= high)
		//	{
		//		int mid = low + (high-low)/2;

		//		//Check if x is present at mid
		//		if (arr[mid] == x)
		//			return mid;

		//		//if x greater, ignore left hand
		//		if (arr[mid] < x)
		//			low = mid+1;

		//		// if x is smaller , ignore right hand
		//		else 
		//			high = mid-1;
		//	}

		//	//If we reach here , then element was not present 
		//	return -1;
		//}

		//static void Main(string[] args)
		//{
		//	int[] arr = { 1, 2, 3, 4, 5, 6 };
		//	int x = 5;

		//	int result = BinarySearch(arr,x);
		//	if (result == -1)
		//		Console.WriteLine("Element is not present in array");
		//	else
		//		Console.WriteLine("Element is present at index  - " + result);

		//	Console.ReadLine();	
		//}

		// 3.Depth First Search Algorithm

		//static void AddEdge(List<List<int>> adj, int s, int t)
		//{
		//	adj[s].Add(t);
		//	adj[t].Add(s);
		//}

		//// Recursive function for DFS traversal
		//static void DfsRec(List<List<int>> adj, bool[] visited, int s)
		//{
		//	// Mark the current vertex as visited
		//	visited[s] = true;

		//	// Print the current vertex
		//	Console.Write(s + " ");

		//	// Recursively visit all adjacent vertices
		//	// that are not visited yet
		//	foreach (int i in adj[s])
		//	{
		//		if (!visited[i])
		//		{
		//			DfsRec(adj, visited, i);
		//		}
		//	}
		//}
		//// Main DFS function that initializes the visited array
		//static void PerformDfs(List<List<int>> adj, int s)
		//{
		//	bool[] visited = new bool[adj.Count];
		//	// Call the recursive DFS function
		//	DfsRec(adj, visited, s);
		//}

		//static void Main(string[] args)
		//{
		//	int v = 5;

		//	// Create an adjancency list for the graph
		//	List<List<int>> adj = new List<List<int>>(v);

		//	for (int i = 0; i < v; i++)
		//	{
		//		adj.Add(new List<int>());
		//	}
		//	// Define the edges of the graph
		//	int[,] edges =
		//	{
		//		{1,2 },
		//		{1,0 },
		//		{2,0 },
		//		{2,3 },
		//		{2,4 }
		//	};
		//	// Populate the adjacency list with edges
		//	for (int i = 0; i < edges.GetLength(0); i++)
		//	{
		//		AddEdge(adj, edges[i, 0], edges[i, 1]);
		//	}
		//	int source = 2; // Starting vertex for DFS
		//	Console.WriteLine("DFS from source - " + source);
		//	PerformDfs(adj, source);

		//	Console.ReadLine();
		//}

		//4.Breadth First Search Algorithm

		//static void BFS(List<List<int>> adj, int s, bool[] visited)
		//{
		//	// Create a queue for BFS
		//	Queue<int> q = new Queue<int>();

		//	// Mark the source node as visited and enqueue it
		//	visited[s] = true;
		//	q.Enqueue(s);

		//	// Iterate over the queue
		//	while (q.Count > 0)
		//	{
		//		// Dequeue a vertex from queue and print it
		//		int curr = q.Dequeue();
		//		Console.Write(curr + " ");

		//		// Get all adjacent vertices of the dequeued vertex
		//		// If an adjacent has not been visited, 
		//		// mark it visited and enqueue it
		//		foreach (int i in adj[curr])
		//		{
		//			if (!visited[i])
		//			{
		//				visited[i] = true;
		//				q.Enqueue(i);
		//			}
		//		}
		//	}
		//}

		//// Function to add an edge to the graph
		//static void AddEdge(List<List<int>> adj, int u, int v)
		//{
		//	adj[u].Add(v);
		//	adj[v].Add(u);
		//}

		//static void Main(string[] args)
		//{
		//	// Number of vertices in the graph
		//	int V = 5;

		//	// Adjacency list representation of the graph
		//	List<List<int>> adj = new List<List<int>>(V);
		//	for (int i = 0; i < V; i++)
		//	{
		//		adj.Add(new List<int>());
		//	}

		//	// Add edges to the graph
		//	int[,] edges = { { 0, 1 }, { 0, 2 }, { 1, 3 }, { 1, 4 }, { 2, 4 } };

		//	for (int i = 0; i < edges.GetLength(0); i++)
		//	{
		//		AddEdge(adj, edges[i, 0], edges[i, 1]);
		//	}

		//	// Mark all the vertices as not visited
		//	bool[] visited = new bool[V];

		//	// Perform BFS traversal starting from vertex 0
		//	Console.WriteLine("BFS starting from 0 : ");
		//	BFS(adj, 0, visited);

		//	Console.ReadLine();
		//}

		//5.Insertion Sort Algorithm

		/* Function to sort array using insertion sort */
		static void Sort(int[] arr)
		{
			int n = arr.Length;
			for(int i= 1;i<n; i++)
			{
				int key = arr[i];
				int j = i - 1;

				/* Move elements of arr[0..i-1], that are
			  greater than key, to one position ahead
			  of their current position */
				while (j >= 0 && arr[j] > key)
				{
					arr[j+1]= arr[j];
					j = j - 1;
				}
				arr[j +1 ] = key;
			}
		}
		/* A utility function to print array of size n */
		static void Print(int[] arr)
		{
			int n = arr.Length;
			for(int i = 0; i < n; i++)
			{
				Console.Write(arr[i] + " ");
			}
			Console.WriteLine();
		}
		static void Main(string[] args)
		{
			int[] arr = { 12, 11, 13, 5, 6 };
			Sort(arr);
			Print(arr);
			Console.ReadLine();	
		}
	}
}