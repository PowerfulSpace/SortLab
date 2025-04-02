namespace SelectionSort
{
    public static class SelectionSorter
    {
        public static void Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if(array[minIndex] > array[j])
                    {
                        minIndex = j;
                    }
                }
                Swap(array, minIndex, i);
            }
        }

        private static void Swap(int[] array, int x, int y)
        {
            int temp = array[x];
            array[x] = array[y];
            array[y] = temp;
        }
    }
}

// выбор минимального элемента и его перемещение в отсортированную часть.