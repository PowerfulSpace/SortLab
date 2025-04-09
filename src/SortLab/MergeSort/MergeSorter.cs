namespace MergeSort
{
    public static class MergeSorter
    {
        public static void Sort(int[] array)
        {
            var sortedList = Separation(array.ToList());

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = sortedList[i];
            }
        }

        // Разделение массива на части
        private static List<int> Separation(List<int> list)
        {
            if (list.Count <= 1) return list;

            var left = Separation(list.GetRange(0, list.Count / 2));
            var right = Separation(list.GetRange(list.Count / 2, list.Count - list.Count / 2));

            return Merge(left, right);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            var merged = new List<int>();
            int i = 0, j = 0;

            while (i < left.Count && j < right.Count)
            {
                if (left[i] <= right[j])
                {
                    merged.Add(left[i]);
                    i++;
                }
                else
                {
                    merged.Add(right[j]);
                    j++;
                }
            }

            merged.AddRange(left.GetRange(i, left.Count - i));

            merged.AddRange(right.GetRange(j, right.Count - j));

            return merged;
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