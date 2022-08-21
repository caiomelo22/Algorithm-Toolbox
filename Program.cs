using algorithms;

int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

// Sorting algorithms

// Console.WriteLine("Bubble Sort: ");
// Sorting.bubbleSort(arr);

Console.Write("Merge Sort: ");
Sorting.mergeSort(arr, 0, arr.Length - 1);

for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]}  ");
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

Console.Write("DFS: ");
g.DFS(2);

Console.Write('\n');

Console.Write("BFS: ");
g.BFS(2);

// Heap 

MinHeap h = new MinHeap(11);
h.InsertKey(3);
h.InsertKey(2);
h.deleteKey(1);
h.InsertKey(15);
h.InsertKey(5);
h.InsertKey(4);
h.InsertKey(45);

Console.Write('\n');
    
Console.Write("EXTRACT MIN HEAP: ");
Console.WriteLine(h.extractMin() + " ");

Console.Write("GET MIN HEAP: ");
Console.WriteLine(h.getMin() + " ");
    
Console.Write("DECREASE KEY AND GET MIN HEAP: ");
h.decreaseKey(2, 1);
Console.WriteLine(h.getMin());
