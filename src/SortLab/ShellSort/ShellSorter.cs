namespace ShellSort
{
    public static class ShellSorter
    {
        public static void Sort(int[] array)
        {
            int gap = array.Length / 2;

            while (gap >= 1)
            {
                for (int i = gap; i < array.Length; i++)
                {
                    int temp = array[i];
                    int j = i;

                    while (j >= gap && array[j - gap] > temp)
                    {
                        array[j] = array[j - gap];
                        j -= gap;
                    }

                    array[j] = temp;
                }

                gap = gap / 2;
            }
        }
    }
}

//улучшение сортировки вставками с использованием промежуточных шагов.