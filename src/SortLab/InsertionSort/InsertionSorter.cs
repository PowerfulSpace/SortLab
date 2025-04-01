namespace InsertionSort
{
    public static class InsertionSorter
    {
        public static void Sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {

                int temp = array[i];
                int j = i - 1;

                while(j >= 0 && temp < array[j])
                {
                    array[j + 1] = array[j];
                    array[j] = temp;
                    j--;
                }
            }

        }

    }
}

//элементы вставляются на нужную позицию в отсортированную часть массива