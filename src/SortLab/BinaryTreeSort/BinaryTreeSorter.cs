namespace BinaryTreeSort
{
    public static class BinaryTreeSorter
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


// создание бинарного дерева из элементов и обход его для сортировки.