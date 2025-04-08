
using MergeSort;

int[] array = { 12, 5, 18, 1, 20, 7, 11, 15, 3, 16, 9, 6, 14, 2, 10, 13, 8, 17, 4, 19 };

Show(array);

MergeSorter.Sort(array);


Console.ReadLine();


void Show(int[] array)
{
    foreach (int i in array)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}