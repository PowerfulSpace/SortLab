namespace CoctailSort
{
    public static class CoctailSorter
    {
        public static void Sort(int[] array)
        {
            bool swapped = true;
            int start = 0;
            int end = array.Length - 1;

            while (swapped)
            {
                swapped = false;

                // Проход слева направо
                for (int i = start; i < end; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        // Меняем элементы местами
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                    }
                }

                // Если ничего не поменялось, массив уже отсортирован
                if (!swapped)
                    break;

                swapped = false;
                end--;

                // Проход справа налево
                for (int i = end - 1; i >= start; i--)
                {
                    if (array[i] > array[i + 1])
                    {
                        // Меняем элементы местами
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                    }
                }

                start++;
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
