namespace MergeSort
{
    public static class MergeSorter
    {
        public static void Sort(int[] array)
        {
        }

        private static void Swap(int[] array, int x, int y)
        {
            int temp = array[x];
            array[x] = array[y];
            array[y] = temp;
        }
    }
}

//разделение массива на части, их сортировка и слияние в отсортированном порядке.