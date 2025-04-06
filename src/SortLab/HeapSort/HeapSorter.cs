namespace HeapSort
{
    public static class HeapSorter
    {
        public static void Sort(int[] array)
        {
            int n = array.Length;

            // 1. Построение Max-Heap
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(array, n, i);
            }

            // 2. Извлечение элементов из кучи
            for (int i = n - 1; i > 0; i--)
            {
                // Перемещаем текущий корень (максимум) в конец массива
                Swap(array, 0, i);

                // Уменьшаем размер кучи и перестраиваем
                Heapify(array, i, 0);
            }
        }

        private static void Heapify(int[] array, int heapSize, int rootIndex)
        {
            int largest = rootIndex; // Изначально корень считается наибольшим
            int leftChild = 2 * rootIndex + 1; // Левый дочерний узел
            int rightChild = 2 * rootIndex + 2; // Правый дочерний узел

            // Если левый дочерний узел больше корня
            if (leftChild < heapSize && array[leftChild] > array[largest])
            {
                largest = leftChild;
            }

            // Если правый дочерний узел больше, чем наибольший на данный момент
            if (rightChild < heapSize && array[rightChild] > array[largest])
            {
                largest = rightChild;
            }

            // Если наибольший элемент не корень, выполняем обмен
            if (largest != rootIndex)
            {
                Swap(array, rootIndex, largest);

                // Рекурсивно просеиваем затронутое поддерево
                Heapify(array, heapSize, largest);
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

//использование структуры данных "куча" для эффективной сортировки.