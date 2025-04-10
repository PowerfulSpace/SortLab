namespace LSD
{
    public static class LSDSorter
    {
        public static void Sort(int[] array)
        {
            int maxNumber = GetMaxNumber(array); // Находим максимальное число для определения количества разрядов
            int maxDigits = GetDigitCount(maxNumber); // Определяем количество разрядов в максимальном числе

            // Сортировка по каждому разряду
            int place = 1; // Единицы, десятки, сотни и т.д.
            for (int i = 0; i < maxDigits; i++)
            {
                CountingSortByPlace(array, place);
                place *= 10; // Переход к следующему разряду
            }
        }
        // Метод для сортировки массива по определённому разряду
        private static void CountingSortByPlace(int[] array, int place)
        {
            int[] output = new int[array.Length]; // Массив для хранения результата
            int[] count = new int[10]; // Диапазон цифр (0-9)

            // Считаем количество повторений каждой цифры для текущего разряда
            foreach (int number in array)
            {
                int digit = (number / place) % 10;
                count[digit]++;
            }

            // Накапливаем количество для корректных позиций
            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            // Заполняем результат, начиная с конца массива
            for (int i = array.Length - 1; i >= 0; i--)
            {
                int digit = (array[i] / place) % 10;
                output[count[digit] - 1] = array[i];
                count[digit]--;
            }

            // Копируем результат обратно в исходный массив
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = output[i];
            }
        }

        // Метод для определения максимального числа в массиве
        private static int GetMaxNumber(int[] array)
        {
            int maxNumber = array[0];
            foreach (int number in array)
            {
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }
            return maxNumber;
        }

        // Метод для подсчёта количества разрядов
        private static int GetDigitCount(int number)
        {
            int count = 0;
            while (number > 0)
            {
                number /= 10;
                count++;
            }
            return count;
        }
    }
}


//сортировка элементов по разрядам, начиная с младших (LSD).