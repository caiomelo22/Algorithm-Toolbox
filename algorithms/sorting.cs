namespace algorithms
{
    public class Sorting
    {
        public static void bubbleSort(int[] arr)
        {
            int size = arr.Length;
            bool swapped = false;

            for (int i = 0; i < size - 1; i++)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        swapped = true;
                        int buffer = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = buffer;
                    }
                }

                if (!swapped)
                {
                    return;
                }
            }
        }
    }
}
