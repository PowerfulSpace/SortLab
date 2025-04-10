namespace CountingSort
{
    public static class CountingSorter
    {
        public static void Sort(int[] array)
        {
            {
                // 1. Определяем минимальное и максимальное значения массива
                int min = array[0];
                int max = array[0];
                foreach (int num in array)
                {
                    if (num < min) min = num;
                    if (num > max) max = num;
                }

                // 2. Создаём массив для подсчёта
                int range = max - min + 1;
                int[] count = new int[range];

                // 3. Подсчитываем повторения каждого элемента
                foreach (int num in array)
                {
                    count[num - min]++;
                }

                // 4. Перезаписываем элементы из count в исходный массив в отсортированном порядке
                int index = 0;
                for (int i = 0; i < range; i++)
                {
                    while (count[i] > 0)
                    {
                        array[index++] = i + min;
                        count[i]--;
                    }
                }
            }
        }
    }
}

//сортировка на основе подсчёта числа вхождений каждого значения в массив.