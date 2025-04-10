namespace MSD
{
    public static class MSDSorter
    {
        public static void Sort(int[] array)
        {
            int maxNumber = GetMaxNumber(array); // Находим максимальное число
            int maxDigits = GetDigitCount(maxNumber); // Определяем максимальное количество разрядов

            // Запускаем рекурсивную сортировку начиная с самого значимого разряда
            SortByDigit(array, 0, array.Length - 1, maxDigits - 1);
        }


        private static void SortByDigit(int[] array, int low, int high, int digitPosition)
        {
            if (low >= high || digitPosition < 0) return; // Базовый случай

            int[] count = new int[10]; // Диапазон цифр (0-9)
            int[] temp = new int[high - low + 1]; // Временный массив для копирования данных

            // Считаем количество повторений цифр для текущего разряда
            for (int i = low; i <= high; i++)
            {
                int digit = GetDigit(array[i], digitPosition);
                count[digit]++;
            }

            // Преобразуем массив count для определения позиций
            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            // Копируем элементы во временный массив в правильном порядке
            for (int i = high; i >= low; i--)
            {
                int digit = GetDigit(array[i], digitPosition);
                temp[--count[digit]] = array[i];
            }

            // Возвращаем отсортированные элементы обратно в массив
            for (int i = 0; i < temp.Length; i++)
            {
                array[low + i] = temp[i];
            }

            // Рекурсивно сортируем каждый "карман"
            int start = low;
            for (int i = 0; i < 10; i++)
            {
                int end = low + count[i] - 1;
                if (start <= end)
                {
                    SortByDigit(array, start, end, digitPosition - 1);
                }
                start = end + 1;
            }
        }

        // Метод для получения цифры на определённой позиции
        private static int GetDigit(int number, int position)
        {
            return (number / (int)Math.Pow(10, position)) % 10;
        }

        // Метод для нахождения максимального числа
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

        // Метод для подсчёта разрядов числа
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

//сортировка элементов по разрядам, начиная с старших (MSD).