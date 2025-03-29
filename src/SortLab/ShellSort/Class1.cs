namespace ShellSort
{
    public class Class1
    {
        static void ShellSort(int[] array)
        {
            int n = array.Length;

            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                // Проходим по элементам с учетом текущего шага
                for (int i = gap; i < n; i++)
                {
                    int temp = array[i]; // Сохраняем текущий элемент
                    int j;

                    // Сравниваем элементы на расстоянии gap
                    for (j = i; j >= gap && array[j - gap] > temp; j -= gap)
                    {
                        array[j] = array[j - gap]; // Сдвигаем элемент вправо
                    }

                    array[j] = temp; // Ставим элемент на нужное место
                }
            }
        }
    }
}
