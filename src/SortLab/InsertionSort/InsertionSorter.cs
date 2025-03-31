namespace InsertionSort
{
    public static class InsertionSorter
    {
        public static void Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if(array[j] > array[i])
                    {
                        Swap(array, j, i);
                    }
                }
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

//элементы вставляются на нужную позицию в отсортированную часть массива