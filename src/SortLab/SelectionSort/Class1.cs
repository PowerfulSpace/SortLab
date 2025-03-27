namespace SelectionSort
{
    public class Class1
    {
        static void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int index = 0; index < n - 1; index++)
            {
                int minIndex = index;

                for (int j = index + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[minIndex];
                arr[minIndex] = arr[index];
                arr[index] = temp;
            }
        }
    }
}
