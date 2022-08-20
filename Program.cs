using algorithms;

int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

// Sorting algorithms

// Console.WriteLine("Bubble Sort: ");
// Sorting.bubbleSort(arr);

Console.WriteLine("Merge Sort: ");
Sorting.mergeSort(arr, 0, arr.Length - 1);

for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]}\t");
}

Console.Write('\n');

// Graph algorithms

Graph g = new Graph(4);
 
g.AddEdge(0, 1);
g.AddEdge(0, 2);
g.AddEdge(1, 2);
g.AddEdge(2, 0);
g.AddEdge(2, 3);
g.AddEdge(3, 3);

Console.WriteLine("DFS: ");
g.DFS(2);

Console.Write('\n');

Console.WriteLine("BFS: ");
g.BFS(2);