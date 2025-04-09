namespace QuickSort
{
    public static class QuickSorter
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

//выбор опорного элемента и разделение массива на меньшие части для дальнейшей сортировки.