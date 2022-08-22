namespace algorithms
{
    public class Search
    {
        public static int binarySearch(int[] arr, int l, int r, int x)
        {
            // O(log(n))
            if (arr.Length == 0)
            {
                return -1;
            }

            int mid = (r - l) / 2 + 1;

            if (arr[mid] == x)
            {
                return mid;
            }
            else if (arr[mid] > x)
            {
                return binarySearch(arr, l, mid - 1, x);
            }
            else
            {
                return binarySearch(arr, mid + 1, r, x);
            }
        }
    }
}