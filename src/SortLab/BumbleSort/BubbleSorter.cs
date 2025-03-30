namespace BumbleSort
{
    public static class BubbleSorter
    {
        public static void Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1; j < array.Length - i; j++)
                {
                    if (array[j - 1] > array[j])
                    {
                        Swap(array, j - 1, j);
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

//многократное сравнение соседних элементов и их обмен, пока массив не отсортируется