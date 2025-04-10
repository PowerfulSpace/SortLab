namespace QuickSort
{
    public static class QuickSorter
    {
        public static void Sort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }

        private static void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(array, low, high);

                QuickSort(array, low, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, high);
            }
        }

        private static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low;

            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    Swap(array, i, j);
                    i++;
                }
            }

            Swap(array, i, high);
            return i;
        }

        private static void Swap(int[] array, int x, int y)
        {
            int temp = array[x];
            array[x] = array[y];
            array[y] = temp;
        }
    }
}

//выбор опорного элемента и разделение массива на меньшие части для дальнейшей сортировки.