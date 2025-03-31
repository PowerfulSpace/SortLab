namespace CoctailSort
{
    public static class CoctailSorter
    {
        public static void Sort(int[] array)
        {
            int start = 0;
            int end = array.Length - 1;

            bool swaped = false;

            while(start < end)
            {
                swaped = false;

                for (int j = start; j < end; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(array, j, j + 1);
                        swaped = true;
                    }
                }

                end--;

                for (int j = end; j > start; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        Swap(array, j - 1, j);
                        swaped = true;
                    }
                }

                start++;

                if (!swaped) { return; }
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


//улучшенная версия пузырьковой сортировки, которая проходит по массиву в обе стороны