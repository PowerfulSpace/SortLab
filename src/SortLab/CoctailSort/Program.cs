

int[] array = { 12, 5, 18, 1, 20, 7, 11, 15, 3, 16, 9, 6, 14, 2, 10, 13, 8, 17, 4, 19 };


Sort(array);



Console.ReadLine();


void Sort(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if(array[j] > array[j + 1])
            {
                Swap(array, j, j + 1);
            }
        }
        for (int k = array.Length - 1; k > 0 + i; k--)
        {
            if (array[k] < array[k - 1])
            {
                Swap(array, k, k - 1);
            }
        }
    }
}

void Swap(int[] array, int x, int y)
{
    int temp = array[x];
    array[x] = array[y];
    array[y] = temp;
}