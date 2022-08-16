namespace algorithms
{
    public class Sorting
    {
        public static void bubbleSort(int[] arr)
        {
            // Time complexity: O(n^2)
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

        private static void mergeSortMerge(int[] arr, int start, int middle, int end) {
            int firstHalfSize = middle - start + 1;
            int secondHalfSize = end - middle;

            int[] L = new int[firstHalfSize];
            int[] R = new int[secondHalfSize];
            int i, j;

            for(i = 0; i < firstHalfSize; i++)
                L[i] = arr[start + i];
            for(j = 0; j < secondHalfSize; j++)
                R[j] = arr[middle + 1 + j];

            i = 0;
            j = 0;

            int k = start;

            while (i < firstHalfSize && j <  secondHalfSize) {
                if(L[i] <= R[j]) {
                    arr[k] = L[i];
                    i++;
                } else {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < firstHalfSize) {
                arr[k] = L[i];
                i++;
                k++;
            }

            while (j < secondHalfSize) {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        public static void mergeSort(int[] arr, int start, int end) {
            // Time complexity is O(n*log(n))
            if (start >= end) {
                return;
            }

            int middle = (start + (end - 1)) / 2;

            mergeSort(arr, start, middle);
            mergeSort(arr, middle + 1, end);

            mergeSortMerge(arr, start, middle, end);
        }
    }
}
