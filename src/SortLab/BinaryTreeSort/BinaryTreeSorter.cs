namespace BinaryTreeSort
{
    public static class BinaryTreeSorter
    {
        public static void Sort(int[] array)
        {
        }
    }

    class Node<T>
    {
        public readonly T value;
        public Node<T> Left { get; set; }
        public Node<T> Right {get;set;}

        public Node(T value)
        {
            this.value = value;
            Left = null!;
            Right = null!;
        }

        public override string ToString()
        {
            return value!.ToString()! ?? "null";
        }
    }
}


// создание бинарного дерева из элементов и обход его для сортировки.