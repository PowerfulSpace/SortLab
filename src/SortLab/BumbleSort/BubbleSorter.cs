namespace BumbleSort
{
    public static class BubbleSorter
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

//многократное сравнение соседних элементов и их обмен, пока массив не отсортируется