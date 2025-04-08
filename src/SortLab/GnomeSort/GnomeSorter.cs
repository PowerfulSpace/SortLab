namespace GnomeSort
{
    public static class GnomeSorter
    {
        public static void Sort(int[] array)
        {
            int index = 0;

            while (index < array.Length - 1)
            {
                while(index >= 0 && array[index] > array[index + 1])
                {
                    Swap(array, index, index + 1);

                    index--;
                }

                index++;
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


//похожа на сортировку вставками, но с меньшим количеством шагов