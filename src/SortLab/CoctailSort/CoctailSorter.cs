﻿namespace CoctailSort
{
    public static class CoctailSorter
    {
        public static void Sort(int[] array)
        {

        }

        private static void Swap(int[] array, int x, int y)
        {
            int temp = array[x];
            array[x] = array[y];
            array[y] = temp;
        }
    }
}