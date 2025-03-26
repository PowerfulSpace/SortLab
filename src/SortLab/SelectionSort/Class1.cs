namespace SelectionSort
{
    public class Class1
    {
        static void SelectionSort(int[] arr)
        {
            int num = arr.Length;

            for (int index = 0; index < num - 1; index++)
            {
                int minIndex = index;

                for (int j = index + 1; j < num; j++)
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
