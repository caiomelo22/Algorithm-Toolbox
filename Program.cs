using static algorithms.Sorting;

int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

bubbleSort(arr);

for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]}\t");
}