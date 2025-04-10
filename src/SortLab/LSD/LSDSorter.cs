namespace LSD
{
    public static class LSDSorter
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


//сортировка элементов по разрядам, начиная с младших (LSD).