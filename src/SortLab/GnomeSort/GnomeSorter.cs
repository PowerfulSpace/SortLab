namespace GnomeSort
{
    public static class GnomeSorter
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


//похожа на сортировку вставками, но с меньшим количеством шагов