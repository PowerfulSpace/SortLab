namespace MergeSort
{
    public static class MergeSorter
    {
        public static void Sort(int[] array)
        {
            Separation(array.ToList());
        }

        private static List<int> Separation(List<int> list)
        {
            if(list.Count == 1) { return list; }

            List<int> left = Separation(list.GetRange(0, list.Count / 2));

            //сортировка

            List<int> rigth = Separation(list.GetRange(list.Count / 2, list.Count - list.Count / 2));

            left.AddRange(rigth);

            return left;
        }


        private static void Swap(int[] array, int x, int y)
        {
            int temp = array[x];
            array[x] = array[y];
            array[y] = temp;
        }
    }
}

//разделение массива на части, их сортировка и слияние в отсортированном порядке.