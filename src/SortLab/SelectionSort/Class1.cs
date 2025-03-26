namespace SelectionSort
{
    public class Class1
    {
        static void SelectionSort(int[] arr)
        {
            int num = arr.Length;

            for (int i = 0; i < num - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < num; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }
    }
}
