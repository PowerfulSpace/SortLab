namespace BinaryTreeSort
{
    public static class BinaryTreeSorter<T> where T: IComparable<T>
    {
        public static void Sort(T[] array)
        {
            Node<T>? root = null;

            foreach (var value in array)
            {
                root = Insert(root, value);
            }

            List<T> sortedList = new List<T>();
            InOrderTraversal(root, sortedList);

            for (int i = 0; i < sortedList.Count; i++)
            {
                array[i] = sortedList[i];
            }
        }
        private static Node<T> Insert<T>(Node<T>? node, T value)
        {
            if (node == null) return new Node<T>(value);

            var comparer = Comparer<T>.Default;
            if (comparer.Compare(value, node.value) < 0)
            {
                node.Left = Insert(node.Left, value);
            }
            else
            {
                node.Right = Insert(node.Right, value);
            }

            return node;
        }

        private static void InOrderTraversal<T>(Node<T>? node, List<T> result)
        {
            if (node == null) return;

            InOrderTraversal(node.Left, result);
            result.Add(node.value);
            InOrderTraversal(node.Right, result);
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