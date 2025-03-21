namespace InsertionSort
{
    public class Class1
    {
        static void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;

                // Сравниваем текущий элемент с элементами отсортированной части массива
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = key;
            }
        }
    }
}
